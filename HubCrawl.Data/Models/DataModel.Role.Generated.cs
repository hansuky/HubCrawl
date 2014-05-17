//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 2014-05-16 오후 2:23:13
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using NHibernate.Classic;
using System.Runtime.Serialization;

namespace HubCrawl.Data
{

    /// <summary>
    /// There are no comments for HubCrawl.Data.Role, HubCrawl.Data in the schema.
    /// </summary>
    [DataContract(IsReference = true)]
    public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged, IValidatable, ICloneable {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _RoleID;

        private string _RoleName;

        private Iesi.Collections.Generic.ISet<UserProfile> _UserProfiles;
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Role toCompare = obj as Role;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.RoleID, toCompare.RoleID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + RoleID.GetHashCode();
          return hashCode;
        }
        /// <summary>
        /// There are no comments for OnRoleIDChanging in the schema.
        /// </summary>
        partial void OnRoleIDChanging(int value);
        
        /// <summary>
        /// There are no comments for OnRoleIDChanged in the schema.
        /// </summary>
        partial void OnRoleIDChanged();
        /// <summary>
        /// There are no comments for OnRoleNameChanging in the schema.
        /// </summary>
        partial void OnRoleNameChanging(string value);
        
        /// <summary>
        /// There are no comments for OnRoleNameChanged in the schema.
        /// </summary>
        partial void OnRoleNameChanged();
        
        #endregion
        /// <summary>
        /// There are no comments for Role constructor in the schema.
        /// </summary>
        public Role()
        {
            this._UserProfiles = new Iesi.Collections.Generic.HashedSet<UserProfile>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for RoleID in the schema.
        /// </summary>
        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int RoleID
        {
            get
            {
                return this._RoleID;
            }
            set
            {
                if (this._RoleID != value)
                {
                    this.OnRoleIDChanging(value);
                    this.SendPropertyChanging();
                    this._RoleID = value;
                    this.SendPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for RoleName in the schema.
        /// </summary>
        [DataMember(Order=2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string RoleName
        {
            get
            {
                return this._RoleName;
            }
            set
            {
                if (this._RoleName != value)
                {
                    this.OnRoleNameChanging(value);
                    this.SendPropertyChanging();
                    this._RoleName = value;
                    this.SendPropertyChanged("RoleName");
                    this.OnRoleNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserProfiles in the schema.
        /// </summary>
        [DataMember(Order=3, EmitDefaultValue=false)]
        public virtual Iesi.Collections.Generic.ISet<UserProfile> UserProfiles
        {
            get
            {
                return this._UserProfiles;
            }
            set
            {
                this._UserProfiles = value;
            }
        }
    
        #region IValidatable Members

        public virtual void Validate()
        {
            OnValidate();
        }

        partial void OnValidate();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            Role obj = new Role();
            obj.RoleID = RoleID;
            obj.RoleName = RoleName;
            return obj;
        }

        #endregion
   
        public virtual event PropertyChangingEventHandler PropertyChanging;

        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
