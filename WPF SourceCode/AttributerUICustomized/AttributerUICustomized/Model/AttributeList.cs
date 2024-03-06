using System.Collections.Generic;

namespace AttributerUI.Model
{
    public class AttributeList
    {   
        public string Description { get; set; }    
        public int Length { get; set; }   
        public string Required { get; set; } 
        public string ControlType { get; set; }       
        public string DefaultValue { get; set; }
        public string HelperTool { get; set; }
    }
    public class jsoncontrollist2
    {
        public List<AttributeList> controls { get; set; }
    }
}
