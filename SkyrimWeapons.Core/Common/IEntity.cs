using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimWeapons.Core.Common
{
    public  interface IEntity<TKey> where TKey : struct
    {
        [Key]
        TKey Id { get; set; }

    }
}
