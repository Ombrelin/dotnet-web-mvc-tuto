using System;

namespace net_web_tuto.Models {
    public class Person {
        public Guid Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}