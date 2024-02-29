using ExampleCore.Dal.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileDal.Roles.Models;
public record RoleDal : BaseEntityDal<Guid>
{
    [Required]
    public string Name { get; init; }
}
