using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Domain.Test
{
    public class SectionFactory
    {

        public static Section Create()
        {
            return new Section(1, "Test Section");
        }
    }
}
