using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Project
{
    [Serializable]
    public class Environment
    {
        public string BaseDirectory { get; set; }
        public bool TabsAreSpaces { get; set; }
        public int TabSize { get; set; }

        public static Environment Default
        {
            get
            {
                return new Environment
                {
                    BaseDirectory = "",
                    TabsAreSpaces = true,
                    TabSize = 4
                };
            }
        }
    }
}
