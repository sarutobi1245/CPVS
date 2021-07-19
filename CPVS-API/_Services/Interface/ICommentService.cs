﻿using CPVS_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPVS_API._Services.Interface
{
    public interface ICommentService : IECService<CommentDto>
    {
        Task<List<CommentDto>> GetAllCommentByScheduleID(int scheduleID);
    }
}