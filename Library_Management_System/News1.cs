﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    
        internal class News1 :IEnumerable
        {
            public static List<Paper> Newspapers = new List<Paper>
        {
            new Paper{Title="Times Of India" },
            new Paper{Title="Economics Times"  },
            new Paper{Title="Hindustan Times" },
        };

            public IEnumerator GetEnumerator()
            {
                if (Newspapers != null)
                {
                    return Newspapers.GetEnumerator();
                }
                else
                {
                    return null;
                }

            }


        }


        public class Paper
        {
            public string Title { get; set; }
        }
    
}
