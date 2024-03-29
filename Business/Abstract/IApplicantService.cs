﻿using Business.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList(Person person);

        bool CheckPerson(Person person);
    }
}
