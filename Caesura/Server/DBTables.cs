﻿using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Server
{
    [Table(Name = "Files")]
    public class CaesFile
    {
        [Column(IsPrimaryKey = true)]
        public string Path;
        [Column]
        public string Name;
    }

    [Table(Name = "PendingMail")]
    public class Mail
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID;
        [Column]
        public string To;
        [Column]
        public string From;
        [Column]
        public string Message;

    }

    [Table(Name = "Tags")]
    public class Tag
    {
        [Column(IsPrimaryKey = true)]
        public String FilePath;
        [Column(IsPrimaryKey = true)]
        public String TagName;
    }

    [Table(Name = "TagNames")]
    public class TagNames
    {
        [Column(IsPrimaryKey = true)]
        public String TagName;
    }

    [Table(Name = "Owns")]
    public class Owner
    {
        [Column(IsPrimaryKey = true)]
        public String Username;
        [Column(IsPrimaryKey = true)]
        public String FilePath;

    }


}
