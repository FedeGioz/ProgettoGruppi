﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProgettoGruppi.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ProgettoGruppiUser class
public class ProgettoGruppiUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName="nvarchar(100)")]
    public String FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public String LastName { get; set; }
}

