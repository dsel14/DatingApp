using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {  
        public int Id { get; set; }
        //Having ? after the string(string? means that it can be nullable)

        
        public string UserName { get; set; }
        
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt { get; set;}
    }
}