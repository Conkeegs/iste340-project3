﻿using Project3_FinalExam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project3_FinalExam.Services
{
    public interface IGetMinors
    {
        Task<List<Minors>> GetMinorList();
    }
}