﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Server
{

    [Table(Name = "Users")]
    public class User
    {
        private String name;
        private String password;


        [Column(IsPrimaryKey = true)]
        public string Username;
        [Column]
        public string PasswordHash;

        public User()
        {
        }

        public User(String username, String password)
        {
            this.Username = username;
            this.password = password;
            this.PasswordHash = password;
        }

        internal void setName(String p)
        {
            if (p == null)
                throw new ArgumentNullException("Name can't be null");
            this.name = p.ToString();
        }

        internal String getName()
        {
            return this.name;
        }

        internal void setPass(String p)
        {
            if (p == null)
                throw new ArgumentNullException("Pass can't be null");
            this.password = p.ToString();
        }

        internal object getPass()
        {
            return this.password;
        }
    }
}
