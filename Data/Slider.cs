using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Slider
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public short PanelType { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
