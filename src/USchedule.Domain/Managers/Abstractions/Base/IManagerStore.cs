﻿namespace USchedule.Domain.Managers.Base
{
    public interface IManagerStore
    {
        IUniversityManager UniversityManager { get; }
        IInstituteManager InstituteManager { get; }
        IDepartmentManager DepartmentManager { get; }
        IGroupManager GroupManager { get; }
        ILessonManager LessonManager { get; }
    }
}