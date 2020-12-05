using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;

using SqlSugarDemo.DAL;
using SqlSugarDemo.IRepository;

namespace SqlSugarDemo.Repository
{
    public class Repository<T> : IRepository<T>
    {
        #region Common
        /// <summary>
        /// Get Client
        /// </summary>
        /// <returns></returns>
        protected SqlSugarClient GetClient()
        {
            return SqlSugarHelper.GetClient();
        }
        #endregion


        #region Query
        #region Query All
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        public IList<T> QueryAll()
        {
            var client = GetClient();

            return client.Queryable<T>().ToList();
        }

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //public IList<T> QueryAll<TKey>(Expression<Func<T, TKey>> keySelector, bool asc)
        //{
        //    IList<T> ls = new List<T>();

        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    if (asc)
        //    {
        //        query = query.OrderBy(keySelector);
        //    }
        //    else
        //    {
        //        query = query.OrderByDescending(keySelector);
        //    }

        //    try
        //    {
        //        ls = query.ToList();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <param name="lsWhere"></param>
        ///// <returns></returns>
        //public IList<T> QueryAll(Expression<Func<T, bool>> where)
        //{
        //    IList<T> ls = new List<T>();

        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    query = query.Where(where);

        //    try
        //    {
        //        ls = query.ToList();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <param name="lsWhere"></param>
        ///// <returns></returns>
        //public IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere)
        //{
        //    IList<T> ls = new List<T>();

        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    foreach (var item in lsWhere)
        //    {
        //        query = query.Where(item);
        //    }

        //    try
        //    {
        //        ls = query.ToList();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="lsWhere"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //public IList<T> QueryAll<TKey>(IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, TKey>> keySelector, bool asc)
        //{
        //    IList<T> ls = new List<T>();

        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    foreach (var item in lsWhere)
        //    {
        //        query = query.Where(item);
        //    }
        //    if (asc)
        //    {
        //        query = query.OrderBy(keySelector);
        //    }
        //    else
        //    {
        //        query = query.OrderByDescending(keySelector);
        //    }

        //    try
        //    {
        //        ls = query.ToList();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="where"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //public IList<T> QueryAll<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> keySelector, bool asc)
        //{
        //    IList<T> ls = new List<T>();

        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    query = query.Where(where);
        //    if (asc)
        //    {
        //        query = query.OrderBy(keySelector);
        //    }
        //    else
        //    {
        //        query = query.OrderByDescending(keySelector);
        //    }

        //    try
        //    {
        //        ls = query.ToList();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();

        //    return ls;
        //}
        #endregion


        #region Query Paging
        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //public IList<T> QueryPaging(int page, int size, out int count)
        //{
        //    IList<T> ls = new List<T>();

        //    count = 0;
        //    var session = OpenSession();
        //    var query = session.Query<T>();

        //    try
        //    {
        //        count = query.Count();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    if (count > 0)
        //    {
        //        query = query.Skip((page - 1) * size).Take(size);

        //        try
        //        {
        //            ls = query.ToList();
        //        }
        //        catch (Exception e)
        //        {
        //            session.Close();
        //            throw e;
        //        }
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //public IList<T> QueryPaging<TKey>(int page, int size, out int count, Expression<Func<T, TKey>> keySelector, bool asc)
        //{
        //    IList<T> ls = new List<T>();

        //    count = 0;
        //    var session = OpenSession();
        //    var query = session.Query<T>();

        //    try
        //    {
        //        count = query.Count();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    if (count > 0)
        //    {
        //        if (asc)
        //        {
        //            query = query.OrderBy(keySelector);
        //        }
        //        else
        //        {
        //            query = query.OrderByDescending(keySelector);
        //        }
        //        query = query.Skip((page - 1) * size).Take(size);

        //        try
        //        {
        //            ls = query.ToList();
        //        }
        //        catch (Exception e)
        //        {
        //            session.Close();
        //            throw e;
        //        }
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, bool>> where)
        //{
        //    IList<T> ls = new List<T>();

        //    count = 0;
        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    query = query.Where(where);

        //    try
        //    {
        //        count = query.Count();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    if (count > 0)
        //    {
        //        query = query.Skip((page - 1) * size).Take(size);

        //        try
        //        {
        //            ls = query.ToList();
        //        }
        //        catch (Exception e)
        //        {
        //            session.Close();
        //            throw e;
        //        }
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="lsWhere"></param>
        ///// <returns></returns>
        //public IList<T> QueryPaging(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere)
        //{
        //    IList<T> ls = new List<T>();

        //    count = 0;
        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    foreach (var item in lsWhere)
        //    {
        //        query = query.Where(item);
        //    }

        //    try
        //    {
        //        count = query.Count();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    if (count > 0)
        //    {
        //        query = query.Skip((page - 1) * size).Take(size);

        //        try
        //        {
        //            ls = query.ToList();
        //        }
        //        catch (Exception e)
        //        {
        //            session.Close();
        //            throw e;
        //        }
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="lsWhere"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //public IList<T> QueryPaging<TKey>(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, TKey>> keySelector, bool asc)
        //{
        //    IList<T> ls = new List<T>();

        //    count = 0;
        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    foreach (var item in lsWhere)
        //    {
        //        query = query.Where(item);
        //    }

        //    try
        //    {
        //        count = query.Count();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    if (count > 0)
        //    {
        //        if (asc)
        //        {
        //            query = query.OrderBy(keySelector);
        //        }
        //        else
        //        {
        //            query = query.OrderByDescending(keySelector);
        //        }
        //        query = query.Skip((page - 1) * size).Take(size);

        //        try
        //        {
        //            ls = query.ToList();
        //        }
        //        catch (Exception e)
        //        {
        //            session.Close();
        //            throw e;
        //        }
        //    }

        //    session.Close();

        //    return ls;
        //}

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="where"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //public IList<T> QueryPaging<TKey>(int page, int size, out int count, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> keySelector, bool asc)
        //{
        //    IList<T> ls = new List<T>();

        //    count = 0;
        //    var session = OpenSession();
        //    var query = session.Query<T>();
        //    query = query.Where(where);

        //    try
        //    {
        //        count = query.Count();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    if (count > 0)
        //    {
        //        if (asc)
        //        {
        //            query = query.OrderBy(keySelector);
        //        }
        //        else
        //        {
        //            query = query.OrderByDescending(keySelector);
        //        }
        //        query = query.Skip((page - 1) * size).Take(size);

        //        try
        //        {
        //            ls = query.ToList();
        //        }
        //        catch (Exception e)
        //        {
        //            session.Close();
        //            throw e;
        //        }
        //    }

        //    session.Close();

        //    return ls;
        //}
        #endregion
        #endregion


        #region Add
        ///// <summary>
        ///// Add
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //public object Add(T entity)
        //{
        //    object obj = new object();

        //    var session = OpenSession();
        //    try
        //    {
        //        obj = session.Save(entity);
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();

        //    return obj;
        //}

        ///// <summary>
        ///// Add
        ///// </summary>
        ///// <param name="entities"></param>
        ///// <returns></returns>
        //public IList<object> Add(IList<T> entities)
        //{
        //    IList<object> ls = new List<object>();

        //    var session = OpenSession();
        //    using (ITransaction transaction = session.BeginTransaction())
        //    {
        //        try
        //        {
        //            foreach (var item in entities)
        //            {
        //                object obj = session.Save(item);
        //                ls.Add(obj);
        //            }
        //            transaction.Commit();
        //        }
        //        catch (HibernateException)
        //        {
        //            transaction.Rollback();
        //            throw;
        //        }
        //    }

        //    return ls;
        //}
        #endregion


        #region Update
        ///// <summary>
        ///// Update
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //public void Update(T entity)
        //{
        //    var session = OpenSession();

        //    try
        //    {
        //        session.SaveOrUpdate(entity);
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();
        //}

        ///// <summary>
        ///// Update
        ///// </summary>
        ///// <param name="entities"></param>
        ///// <returns></returns>
        //public void Update(IList<T> entities)
        //{
        //    var session = OpenSession();
        //    using (ITransaction transaction = session.BeginTransaction())
        //    {
        //        try
        //        {
        //            foreach (var item in entities)
        //            {
        //                session.SaveOrUpdate(item);
        //            }
        //            transaction.Commit();
        //        }
        //        catch (HibernateException e)
        //        {
        //            transaction.Rollback();
        //            throw e;
        //        }
        //    }

        //    session.Close();
        //}
        #endregion


        #region Delete
        ///// <summary>
        ///// Delete
        ///// </summary>
        ///// <param name="entity"></param>
        //public void Delete(T entity)
        //{
        //    var session = OpenSession();

        //    try
        //    {
        //        session.Delete(entity);
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();
        //}

        ///// <summary>
        ///// Delete
        ///// </summary>
        ///// <param name="key"></param>
        //public void Delete(object key)
        //{
        //    var session = OpenSession();

        //    try
        //    {
        //        T t = session.Get<T>(key);
        //        if (t != null)
        //        {
        //            session.Delete(t);
        //        }

        //        session.Flush();
        //    }
        //    catch (Exception e)
        //    {
        //        session.Close();
        //        throw e;
        //    }

        //    session.Close();
        //}
        #endregion
    }
}
