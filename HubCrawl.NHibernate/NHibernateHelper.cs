using System;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace HubCrawl.NHibernate
{
    public class SessionProvider
    {
        private ISession _session;
        private ISessionFactory _sessionFac;
        private bool _reuseSession;

        protected const String DefaultConfigFileName = "Database.cfg.xml";

        public String ConfigFileName
        {
            get
            {
                var confSetting = System.Configuration.ConfigurationManager.AppSettings["NHibernateCfgFile"];
                return confSetting == null ? DefaultConfigFileName : confSetting;
            }
        }

        #region Thread-safe Singleton

        public static SessionProvider Instance
        {
            get
            {
                return Nested.TheSingleton;
            }
        }

        public static SessionProvider NewSession
        {
            get
            {
                return new SessionProvider();
            }
        }

        private String AssemblyName
        {
            get
            {
                //return "HubCrawl.Data.Mapping";
                return this.GetType().Assembly.GetName().Name;
            }
        }

        private SessionProvider()
        {
            // Read the configuration
            Configuration cfg = new Configuration();
            cfg.Configure(ConfigFileName);
            cfg.AddAssembly(AssemblyName);
            BuildSchema(cfg);
            _sessionFac = cfg.BuildSessionFactory();
            _reuseSession = false;
        }

        private void BuildSchema(Configuration config)
        {
            var cfg = Fluently.Configure(config);
            if (!Validation(config))
                new SchemaExport(config).Create(false, true);
        }

        private Boolean Validation(Configuration config)
        {
            try
            {
                SchemaValidator schemeValidator = new SchemaValidator(config);
                schemeValidator.Validate();
                return true;
            }
            catch { return false; }
        }

        private class Nested
        {
            static Nested() { }
            internal static readonly SessionProvider
                TheSingleton = new SessionProvider();
        }

        #endregion


        /// <summary>
        /// Should the session be reused? If
        /// this property is false (default), a Session-Per-Request
        /// is applied.
        /// </summary>
        public bool ReuseSession
        {
            get
            {
                return _reuseSession;
            }
            set
            {
                _reuseSession = value;
            }
        }

        /// <summary>
        /// Get the current session. If the session is null,
        /// Open a new Session
        /// </summary>
        /// <returns>ISession-Object</returns>
        public ISession GetSession()
        {
            if (_session == null)
                _session = _sessionFac.OpenSession();
            if (!_session.IsOpen)
                _session = _sessionFac.OpenSession();

            return _session;

        }

        /// <summary>
        /// Close a Session, if the flag ReuseSession is false
        /// </summary>
        public void CloseSession()
        {
            if (_session != null)
            {
                if (!_reuseSession)
                {
                    _session.Close();
                    _session = null;
                }
            }
        }
    }
}
