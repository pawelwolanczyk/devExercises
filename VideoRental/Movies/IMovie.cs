﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    public interface IMovie
    {
        string Title { get; set; }

        bool IsAvailable { get; }

        bool Rent(DateTime Start, DateTime endTime);
    }
}
