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
    /// There are no comments for HubCrawl.Data.UserProfile, HubCrawl.Data in the schema.
    /// </summary>
    [DataContract(IsReference = true)]
    public partial class UserProfile : INotifyPropertyChanging, INotifyPropertyChanged, IValidatable, ICloneable {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private string _UserID;

        private string _FirstName;

        private string _LastName;

        private string _PhoneNumber;

        private string _Email;

        private Iesi.Collections.Generic.ISet<Role> _Roles;

        private MemberShip _MemberShip;
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          UserProfile toCompare = obj as UserProfile;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.UserID, toCompare.UserID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + UserID.GetHashCode();
          return hashCode;
        }
        /// <summary>
        /// There are no comments for OnUserIDChanging in the schema.
        /// </summary>
        partial void OnUserIDChanging(string value);
        
        /// <summary>
        /// There are no comments for OnUserIDChanged in the schema.
        /// </summary>
        partial void OnUserIDChanged();
        /// <summary>
        /// There are no comments for OnFirstNameChanging in the schema.
        /// </summary>
        partial void OnFirstNameChanging(string value);
        
        /// <summary>
        /// There are no comments for OnFirstNameChanged in the schema.
        /// </summary>
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for OnLastNameChanging in the schema.
        /// </summary>
        partial void OnLastNameChanging(string value);
        
        /// <summary>
        /// There are no comments for OnLastNameChanged in the schema.
        /// </summary>
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for OnPhoneNumberChanging in the schema.
        /// </summary>
        partial void OnPhoneNumberChanging(string value);
        
        /// <summary>
        /// There are no comments for OnPhoneNumberChanged in the schema.
        /// </summary>
        partial void OnPhoneNumberChanged();
        /// <summary>
        /// There are no comments for OnEmailChanging in the schema.
        /// </summary>
        partial void OnEmailChanging(string value);
        
        /// <summary>
        /// There are no comments for OnEmailChanged in the schema.
        /// </summary>
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for OnMemberShipChanging in the schema.
        /// </summary>
        partial void OnMemberShipChanging(MemberShip value);

        /// <summary>
        /// There are no comments for OnMemberShipChanged in the schema.
        /// </summary>
        partial void OnMemberShipChanged();
        
        #endregion
        /// <summary>
        /// There are no comments for UserProfile constructor in the schema.
        /// </summary>
        public UserProfile()
        {
            this._Roles = new Iesi.Collections.Generic.HashedSet<Role>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for UserID in the schema.
        /// </summary>
        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if (this._UserID != value)
                {
                    this.OnUserIDChanging(value);
                    this.SendPropertyChanging();
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");
                    this.OnUserIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        [DataMember(Order=2)]
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if (this._FirstName != value)
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging();
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        [DataMember(Order=3)]
        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if (this._LastName != value)
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging();
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for PhoneNumber in the schema.
        /// </summary>
        [DataMember(Order=4)]
        public virtual string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }
            set
            {
                if (this._PhoneNumber != value)
                {
                    this.OnPhoneNumberChanging(value);
                    this.SendPropertyChanging();
                    this._PhoneNumber = value;
                    this.SendPropertyChanged("PhoneNumber");
                    this.OnPhoneNumberChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        [DataMember(Order=5)]
        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if (this._Email != value)
                {
                    this.OnEmailChanging(value);
                    this.SendPropertyChanging();
                    this._Email = value;
                    this.SendPropertyChanged("Email");
                    this.OnEmailChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Roles in the schema.
        /// </summary>
        [DataMember(Order=6, EmitDefaultValue=false)]
        public virtual Iesi.Collections.Generic.ISet<Role> Roles
        {
            get
            {
                return this._Roles;
            }
            set
            {
                this._Roles = value;
            }
        }

    
        /// <summary>
        /// There are no comments for MemberShip in the schema.
        /// </summary>
        public virtual MemberShip MemberShip
        {
            get
            {
                return this._MemberShip;
            }
            set
            {
                if (this._MemberShip != value)
                {
                    this.OnMemberShipChanging(value);
                    this.SendPropertyChanging();
                    this._MemberShip = value;
                    this.SendPropertyChanged("MemberShip");
                    this.OnMemberShipChanged();
                }
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
            UserProfile obj = new UserProfile();
            obj.UserID = UserID;
            obj.FirstName = FirstName;
            obj.LastName = LastName;
            obj.PhoneNumber = PhoneNumber;
            obj.Email = Email;
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
