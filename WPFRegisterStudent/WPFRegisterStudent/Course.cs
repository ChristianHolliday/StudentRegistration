﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPFRegisterStudent
{
    class Course
    {
        public string name = "";
        private bool isRegisteredAlready = false;

        public Course(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public bool IsRegisteredAlready()
        {
            return isRegisteredAlready;
        }

        public void SetToRegistered()
        {
            isRegisteredAlready = true;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
