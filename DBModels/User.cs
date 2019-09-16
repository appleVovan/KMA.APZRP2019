﻿using System;

namespace KMA.APZRP2019.DBModels
{
    public class User:IDBModel
    {
        #region Fields
        private Guid _guid;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        #endregion

        #region Properties
        public Guid Guid
        {
            get
            {
                return _guid;
            }
            private set
            {
                _guid = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            private set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            private set
            {
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set { _password = value; }
        }
        #endregion

        #region Constructor

        public User(string firstName, string lastName, string email, string password)
        {
            _guid = Guid.NewGuid();
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            SetPassword(password);
        }

        public User()
        {
            
        }
        #endregion

        private void SetPassword(string password)
        {
            //TODO Add encription
            _password = password;
        }

        internal bool CheckPassword(string password)
        {
            //TODO Compare encrypted passwords
            return _password == password;
        }
        
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}