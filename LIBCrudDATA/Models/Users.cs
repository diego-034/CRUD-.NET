using System;

namespace LIBCrudDATA.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public string Document { get; set; }
    }
}
