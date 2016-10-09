using System;
using System.Collections.Generic;
using ZoolandiaRazor.Models;
using System.Linq;
using System.Web;

namespace ZoolandiaRazor.DAL
{
    public class ZooRepository
    {
        public ZooContext Context { get; set; }
        public ZooRepository()
        {
            Context = new ZooContext();
        }
        public ZooRepository(ZooContext _context)
        {
            Context = _context;
        }
    }
}