﻿using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Entities;
//using FluentValidation;

namespace Task.Domain.Interfaces
{
  public  class IBaseService<TEntity> where TEntity : BaseEntity
    {
        //TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        //void Delete(int id);

        //IList<TEntity> Get();

        //TEntity GetById(int id);

        //TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}