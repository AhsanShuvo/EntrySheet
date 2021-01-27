﻿using EntrySheet.Web.Data;
using System.Collections.Generic;

namespace EntrySheet.Web.Interfaces
{
    public interface IProjectUserRepository
    {
        bool AddNewUser(ProjectUser model);
        List<ProjectUser> GetAssignedUsers(int projectId);
        bool RemoveAssignedUser(ProjectUser model);
    }
}