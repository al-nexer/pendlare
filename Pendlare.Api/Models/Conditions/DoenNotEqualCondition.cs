﻿namespace Pendlare.Api.Models.Conditions
{
    public class DoenNotEqualCondition : GenericCondition
    {
        public DoenNotEqualCondition() : base() { }
        public DoenNotEqualCondition(string name, string value) : base(name, value) { }
        public DoenNotEqualCondition(string name, int minutes) : base(name, minutes) { }
    }
}
