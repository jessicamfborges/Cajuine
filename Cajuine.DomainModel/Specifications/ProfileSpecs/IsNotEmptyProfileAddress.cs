﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Entities;

namespace Cajuine.DomainModel.Specifications.ProfileSpecs
{
    public class IsNotEmptyProfileAddress : ProfileEntityValidation
    {
        public new static bool IsValid(Profile profile)
        {
            return !String.IsNullOrEmpty(profile.Address);

            //Outra opção:
            //if (_profile.Address == "")
            //    return false;
            //return true;
        }
    }
}
