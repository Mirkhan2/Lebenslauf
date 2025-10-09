using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Application.Generator
{
    public static class CodeGenerator
    {
        public static string GenerateUniqCode()
        {
            throw new NotImplementedException();
        }

        public static string GenericUniqCode()
        {
            // Generate a unique string (e.g., based on a GUID)
            return Guid.NewGuid().ToString("N"); // "N" removes dashes
        }
    }

}
