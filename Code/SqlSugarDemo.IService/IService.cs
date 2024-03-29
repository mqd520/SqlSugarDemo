﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarDemo.IService
{
    /// <summary>
    /// Service Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IService<T> where T : class, new()
    {
        #region Query
        #region Query Single
        #region Query Single Sync
        /// <summary>
        /// Query Single
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T QuerySingleById<Tkey>(Tkey id);

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T QuerySingle(Expression<Func<T, bool>> where);

        /// <summary>
        /// Query Single
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        T QuerySingle(IEnumerable<Expression<Func<T, bool>>> wheres);
        #endregion


        #region Query Single Async
        /// <summary>
        /// Query Single
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> QuerySingleByIdAsync<Tkey>(Tkey id);

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        Task<T> QuerySingleAsync(Expression<Func<T, bool>> where);

        /// <summary>
        /// Query Single
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        Task<T> QuerySingleAsync(IEnumerable<Expression<Func<T, bool>>> wheres);
        #endregion
        #endregion


        #region Query All
        #region Query All Sync
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        IList<T> QueryAll();

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        IList<T> QueryAll(Expression<Func<T, object>> keySelector, bool asc);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        IList<T> QueryAll(Expression<Func<T, bool>> where);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="where"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        IList<T> QueryAll(Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc);
        #endregion


        #region Query All Async
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        Task<IList<T>> QueryAllAsync();

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        Task<IList<T>> QueryAllAsync(Expression<Func<T, object>> keySelector, bool asc);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        Task<IList<T>> QueryAllAsync(Expression<Func<T, bool>> where);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        Task<IList<T>> QueryAllAsync(IList<Expression<Func<T, bool>>> lsWhere);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        Task<IList<T>> QueryAllAsync(IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc);

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="where"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        Task<IList<T>> QueryAllAsync(Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc);
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
        IList<T> QueryPaging(int page, int size, out int count);

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, object>> keySelector, bool asc);

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, bool>> where);

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        IList<T> QueryPaging(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere);

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
        IList<T> QueryPaging(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc);

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
        IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc);
        #endregion


        #region Query Paging Async
        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <returns></returns>
        Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle);

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, Expression<Func<T, object>> keySelector, bool asc);

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, Expression<Func<T, bool>> where);

        /// <summary>
        /// Query Paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="recvTotalRecordsHandle"></param>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, IList<Expression<Func<T, bool>>> lsWhere);

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
        Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, object>> keySelector, bool asc);

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
        Task<IList<T>> QueryPagingAsync(int page, int size, Action<int> recvTotalRecordsHandle, Expression<Func<T, bool>> where, Expression<Func<T, object>> keySelector, bool asc);
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
        int Add(T entity);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T AddAndReturn(T entity);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Add(IEnumerable<T> entities);
        #endregion


        #region Add Async
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> AddAsync(T entity);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> AddAndReturnAsync(T entity);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> AddAsync(IEnumerable<T> entities);
        #endregion
        #endregion


        #region Update
        #region Update Sync
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Update(IEnumerable<T> entities);
        #endregion


        #region Update Async
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(IEnumerable<T> entities);
        #endregion
        #endregion


        #region Delete
        #region Delete Sync
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        int Delete(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        int Delete(IEnumerable<T> entities);

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete<TKey>(TKey id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete<TKey>(IEnumerable<TKey> ids);
        #endregion


        #region Delete Async
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        Task<int> DeleteAsync(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        Task<int> DeleteAsync(IEnumerable<T> entities);

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DeleteAsync<TKey>(TKey id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DeleteAsync<TKey>(IEnumerable<TKey> ids);
        #endregion
        #endregion
    }
}
