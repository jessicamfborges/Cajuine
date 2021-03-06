﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;

namespace Cajuine.DataAccess.Repositories
{
    public class PhotoLocalFileRepository : IPhotoRepository
    {
        public string Create(Photo photo)
        {
            using (FileStream output = new FileStream(@"F:\Blobs\copies\" + photo.FileName, FileMode.Create))
            {
                photo.BinaryContent.CopyTo(output);
            }
            return @"F:\Blobs\copies\" + photo.FileName;
        }

        public Task<string> CreateAsync(Photo photo)
        {
            throw new NotImplementedException();
        }
    }
}
