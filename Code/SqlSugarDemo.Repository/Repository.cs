﻿using System;
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
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        #region Common
        /// <summary>
        /// Get Db
        /// </summary>
        /// <returns></returns>
        protected SqlSugarClient GetDb()
        {
            return SqlSugarHelper.GetDb();
        }
        #endregion


        #region Query
        #region Query Single
        #region Query Single Sync
        /// <summary>
        /// Query Single
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T QuerySingleById<Tkey>(Tkey id)
        {
            using (var db = GetDb())
            {
                return db.Queryable<T>().In<Tkey>(id).First();
            }
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T QuerySingle(Expression<Func<T, bool>> where)
        {
            using (var db = GetDb())
            {
                return db.Queryable<T>().Where(where).First();
            }
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T QuerySingle(IEnumerable<Expression<Func<T, bool>>> wheres)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                foreach (var item in wheres)
                {
                    query = query.Where(item);
                }

                return query.First();
            }
        }
        #endregion


        #region Query Single Async
        /// <summary>
        /// Query Single
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<T> QuerySingleByIdAsync<Tkey>(Tkey id)
        {
            using (var db = GetDb())
            {
                return await db.Queryable<T>().In<Tkey>(id).FirstAsync();
            }
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual async Task<T> QuerySingleAsync(Expression<Func<T, bool>> where)
        {
            using (var db = GetDb())
            {
                return await db.Queryable<T>().Where(where).FirstAsync();
            }
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual async Task<T> QuerySingleAsync(IEnumerable<Expression<Func<T, bool>>> wheres)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                foreach (var item in wheres)
                {
                    query = query.Where(item);
                }

                return await query.FirstAsync();
            }
        }
        #endregion
        #endregion


        #region Query All
        #region Query All Sync
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        public virtual IList<T> QueryAll()
        {
            using (var db = GetDb())
            {
                return db.Queryable<T>().Take(10).ToList();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                if (asc)
                {
                    query = query.OrderBy(keySelector, OrderByType.Asc);
                }
                else
                {
                    query = query.OrderBy(keySelector, OrderByType.Desc);
                }

                return query.ToList();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(Expression<Func<T, bool>> where)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                query = query.Where(where);

                return query.ToList();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }

                return query.ToList();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }
                if (asc)
                {
                    query = query.OrderBy(keySelector, OrderByType.Asc);
                }
                else
                {
                    query = query.OrderBy(keySelector, OrderByType.Desc);
                }

                return query.ToList();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="where"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                query = query.Where(where);
                if (asc)
                {
                    query = query.OrderBy(keySelector, OrderByType.Asc);
                }
                else
                {
                    query = query.OrderBy(keySelector, OrderByType.Desc);
                }

                return query.ToList();
            }
        }
        #endregion


        #region Query All Async
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync()
        {
            using (var db = GetDb())
            {
                return await db.Queryable<T>().Take(10).ToListAsync();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                if (asc)
                {
                    query = query.OrderBy(keySelector, OrderByType.Asc);
                }
                else
                {
                    query = query.OrderBy(keySelector, OrderByType.Desc);
                }

                return await query.ToListAsync();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(Expression<Func<T, bool>> where)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                query = query.Where(where);

                return await query.ToListAsync();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(IList<Expression<Func<T, bool>>> lsWhere)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }

                return await query.ToListAsync();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }
                if (asc)
                {
                    query = query.OrderBy(keySelector, OrderByType.Asc);
                }
                else
                {
                    query = query.OrderBy(keySelector, OrderByType.Desc);
                }

                return await query.ToListAsync();
            }
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="where"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                var query = db.Queryable<T>();
                query = query.Where(where);
                if (asc)
                {
                    query = query.OrderBy(keySelector, OrderByType.Asc);
                }
                else
                {
                    query = query.OrderBy(keySelector, OrderByType.Desc);
                }

                return await query.ToListAsync();
            }
        }
        #endregion
        #endregion


        #region Query Paging
        #region Query Paging Sync
        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual IList<T> QueryPaging(int page, int size, out int count)
        {
            using (var db = GetDb())
            {
                count = 0;
                var query = db.Queryable<T>();

                count = query.Count();
                if (count > 0)
                {
                    query = query.Skip((page - 1) * size).Take(size);

                    return query.ToList();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                count = 0;
                var query = db.Queryable<T>();

                count = query.Count();
                if (count > 0)
                {
                    if (asc)
                    {
                        query = query.OrderBy(keySelector, OrderByType.Asc);
                    }
                    else
                    {
                        query = query.OrderBy(keySelector, OrderByType.Desc);
                    }

                    query = query.Skip((page - 1) * size).Take(size);

                    return query.ToList();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, bool>> where)
        {
            using (var db = GetDb())
            {
                count = 0;
                var query = db.Queryable<T>();
                query = query.Where(where);

                count = query.Count();
                if (count > 0)
                {
                    query = query.Skip((page - 1) * size).Take(size);

                    return query.ToList();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual IList<T> QueryPaging(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere)
        {
            using (var db = GetDb())
            {
                count = 0;
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }

                count = query.Count();
                if (count > 0)
                {
                    query = query.Skip((page - 1) * size).Take(size);

                    return query.ToList();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="lsWhere"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual IList<T> QueryPaging(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                count = 0;
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }

                count = query.Count();
                if (count > 0)
                {
                    if (asc)
                    {
                        query = query.OrderBy(keySelector, OrderByType.Asc);
                    }
                    else
                    {
                        query = query.OrderBy(keySelector, OrderByType.Desc);
                    }
                    query = query.Skip((page - 1) * size).Take(size);

                    return query.ToList();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="where"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                count = 0;
                var query = db.Queryable<T>();
                query = query.Where(where);

                count = query.Count();
                if (count > 0)
                {
                    if (asc)
                    {
                        query = query.OrderBy(keySelector, OrderByType.Asc);
                    }
                    else
                    {
                        query = query.OrderBy(keySelector, OrderByType.Desc);
                    }
                    query = query.Skip((page - 1) * size).Take(size);

                    return query.ToList();
                }
                else
                {
                    return new List<T>();
                }
            }
        }
        #endregion


        #region Query Paging Async
        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle)
        {
            using (var db = GetDb())
            {
                int count = 0;
                var query = db.Queryable<T>();

                count = await query.CountAsync();
                if (recvTotalRecordsHandle != null)
                {
                    recvTotalRecordsHandle.Invoke(count);
                }

                if (count > 0)
                {
                    query = query.Skip((page - 1) * size).Take(size);

                    return await query.ToListAsync();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                int count = 0;
                var query = db.Queryable<T>();

                count = await query.CountAsync();
                if (recvTotalRecordsHandle != null)
                {
                    recvTotalRecordsHandle.Invoke(count);
                }

                if (count > 0)
                {
                    if (asc)
                    {
                        query = query.OrderBy(keySelector, OrderByType.Asc);
                    }
                    else
                    {
                        query = query.OrderBy(keySelector, OrderByType.Desc);
                    }

                    query = query.Skip((page - 1) * size).Take(size);

                    return await query.ToListAsync();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, Expression<Func<T, bool>> where)
        {
            using (var db = GetDb())
            {
                int count = 0;
                var query = db.Queryable<T>();
                query = query.Where(where);

                count = await query.CountAsync();
                if (recvTotalRecordsHandle != null)
                {
                    recvTotalRecordsHandle.Invoke(count);
                }

                if (count > 0)
                {
                    query = query.Skip((page - 1) * size).Take(size);

                    return await query.ToListAsync();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, IList<Expression<Func<T, bool>>> lsWhere)
        {
            using (var db = GetDb())
            {
                int count = 0;
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }

                count = await query.CountAsync();
                if (recvTotalRecordsHandle != null)
                {
                    recvTotalRecordsHandle.Invoke(count);
                }

                if (count > 0)
                {
                    query = query.Skip((page - 1) * size).Take(size);

                    return await query.ToListAsync();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="lsWhere"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                int count = 0;
                var query = db.Queryable<T>();
                foreach (var item in lsWhere)
                {
                    query = query.Where(item);
                }

                count = await query.CountAsync();
                if (recvTotalRecordsHandle != null)
                {
                    recvTotalRecordsHandle.Invoke(count);
                }

                if (count > 0)
                {
                    if (asc)
                    {
                        query = query.OrderBy(keySelector, OrderByType.Asc);
                    }
                    else
                    {
                        query = query.OrderBy(keySelector, OrderByType.Desc);
                    }
                    query = query.Skip((page - 1) * size).Take(size);

                    return await query.ToListAsync();
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="where"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc)
        {
            using (var db = GetDb())
            {
                int count = 0;
                var query = db.Queryable<T>();
                query = query.Where(where);

                count = await query.CountAsync();
                if (recvTotalRecordsHandle != null)
                {
                    recvTotalRecordsHandle.Invoke(count);
                }

                if (count > 0)
                {
                    if (asc)
                    {
                        query = query.OrderBy(keySelector, OrderByType.Asc);
                    }
                    else
                    {
                        query = query.OrderBy(keySelector, OrderByType.Desc);
                    }
                    query = query.Skip((page - 1) * size).Take(size);

                    return await query.ToListAsync();
                }
                else
                {
                    return new List<T>();
                }
            }
        }
        #endregion
        #endregion
        #endregion


        #region Add
        #region Add Sync
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int Add(T entity)
        {
            using (var db = GetDb())
            {
                return db.Insertable<T>(entity).ExecuteReturnIdentity();
            }
        }

        /// <summary>
        /// Add1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T AddAndReturn(T entity)
        {
            using (var db = GetDb())
            {
                return db.Insertable<T>(entity).ExecuteReturnEntity();
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Add(IEnumerable<T> entities)
        {
            using (var db = GetDb())
            {
                return db.Insertable<T>(entities.ToArray()).ExecuteCommand();
            }
        }
        #endregion


        #region Add Async
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<int> AddAsync(T entity)
        {
            using (var db = GetDb())
            {
                return await db.Insertable<T>(entity).ExecuteReturnIdentityAsync();
            }
        }

        /// <summary>
        /// Add1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<T> AddAndReturnAsync(T entity)
        {
            using (var db = GetDb())
            {
                return await db.Insertable<T>(entity).ExecuteReturnEntityAsync();
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> AddAsync(IEnumerable<T> entities)
        {
            using (var db = GetDb())
            {
                return await db.Insertable<T>(entities.ToArray()).ExecuteCommandAsync();
            }
        }
        #endregion
        #endregion


        #region Update
        #region Update Sync
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int Update(T entity)
        {
            using (var db = GetDb())
            {
                return db.Updateable<T>(entity).ExecuteCommand();
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Update(IEnumerable<T> entities)
        {
            using (var db = GetDb())
            {
                return db.Updateable<T>(entities.ToList()).ExecuteCommand();
            }
        }
        #endregion


        #region Update Async
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<int> UpdateAsync(T entity)
        {
            using (var db = GetDb())
            {
                return await db.Updateable<T>(entity).ExecuteCommandAsync();
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> UpdateAsync(IEnumerable<T> entities)
        {
            using (var db = GetDb())
            {
                return await db.Updateable<T>(entities.ToList()).ExecuteCommandAsync();
            }
        }
        #endregion
        #endregion


        #region Delete
        #region Delete Sync
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual int Delete(T entity)
        {
            using (var db = GetDb())
            {
                return db.Deleteable<T>().ExecuteCommand();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual int Delete(IEnumerable<T> entities)
        {
            using (var db = GetDb())
            {
                return db.Deleteable<T>().Where(entities.ToList()).ExecuteCommand();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual int Delete<TKey>(TKey id)
        {
            using (var db = GetDb())
            {
                return db.Deleteable<T>().In<TKey>(id).ExecuteCommand();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual int Delete<TKey>(IEnumerable<TKey> ids)
        {
            using (var db = GetDb())
            {
                return db.Deleteable<T>().In<TKey>(ids.ToArray()).ExecuteCommand();
            }
        }
        #endregion


        #region Delete Async
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task<int> DeleteAsync(T entity)
        {
            using (var db = GetDb())
            {
                return await db.Deleteable<T>().ExecuteCommandAsync();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task<int> DeleteAsync(IEnumerable<T> entities)
        {
            using (var db = GetDb())
            {
                return await db.Deleteable<T>().Where(entities.ToList()).ExecuteCommandAsync();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync<TKey>(TKey id)
        {
            using (var db = GetDb())
            {
                return await db.Deleteable<T>().In<TKey>(id).ExecuteCommandAsync();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync<TKey>(IEnumerable<TKey> ids)
        {
            using (var db = GetDb())
            {
                return await db.Deleteable<T>().In<TKey>(ids.ToArray()).ExecuteCommandAsync();
            }
        }
        #endregion
        #endregion
    }
}
