﻿using Domain.Models;
using Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Repository.Generic
{
    public class GenericRepository<T>: IRepository<T> where T : BaseEntity
    { 

    private MySQLContext _context;

    private DbSet<T> dataset;

    public GenericRepository(MySQLContext context)
    {
        _context = context;
        dataset = _context.Set<T>();
    }

    // Method responsible for returning all Books,
    public List<T> FindAll()
    {
        return dataset.ToList();
    }

    public T FindById(long id)
    {
        return dataset.SingleOrDefault(p => p.Id.Equals(id));
    }


    public T Create(T item)
    {
        try
        {
            dataset.Add(item);
            _context.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
        return item;
    }


    public T Update(T item)
    {

        if (!Exists(item.Id)) return null;

        // Get the current status of the record in the database
        var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
        if (result != null)
        {
            try
            {
                // set changes and save
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        else
        {
            return null;
        }
    }

    // Method responsible for deleting a book from an ID
    public void Delete(long id)
    {
        var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
        if (result != null)
        {
            try
            {
                dataset.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public bool Exists(long id)
    {
        return dataset.Any(p => p.Id.Equals(id));
    }
}
}
