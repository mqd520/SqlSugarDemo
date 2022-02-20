using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using SqlSugarDemo.IRepository;
using SqlSugarDemo.Repository;

namespace SqlSugarDemo.Service
{
    /// <summary>
    /// Service
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Service<T> where T : class, new()
    {
        #region Property
        protected IRepository<T> Repository { get { return new Repository<T>(); } }
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
            return Repository.QuerySingleById<Tkey>(id);
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T QuerySingle(Expression<Func<T, bool>> where)
        {
            return Repository.QuerySingle(where);
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T QuerySingle(IEnumerable<Expression<Func<T, bool>>> wheres)
        {
            return Repository.QuerySingle(wheres);
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
            return await Repository.QuerySingleByIdAsync<Tkey>(id);
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual async Task<T> QuerySingleAsync(Expression<Func<T, bool>> where)
        {
            return await Repository.QuerySingleAsync(where);
        }

        /// <summary>
        /// Query Single
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual async Task<T> QuerySingleAsync(IEnumerable<Expression<Func<T, bool>>> wheres)
        {
            return await Repository.QuerySingleAsync(wheres);
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
            return Repository.QueryAll();
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(Expression<Func<T, object>> keySelector, bool asc)
        {
            return Repository.QueryAll(keySelector, asc);
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(Expression<Func<T, bool>> where)
        {
            return Repository.QueryAll(where);
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere)
        {
            return Repository.QueryAll(lsWhere);
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
            return Repository.QueryAll(lsWhere, keySelector, asc);
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
            return Repository.QueryAll(where, keySelector, asc);
        }
        #endregion


        #region Query All Async
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync()
        {
            return await Repository.QueryAllAsync();
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="keySelector"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(Expression<Func<T, object>> keySelector, bool asc)
        {
            return await Repository.QueryAllAsync(keySelector, asc);
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(Expression<Func<T, bool>> where)
        {
            return await Repository.QueryAllAsync(where);
        }

        /// <summary>
        /// Query All
        /// </summary>
        /// <param name="lsWhere"></param>
        /// <returns></returns>
        public virtual async Task<IList<T>> QueryAllAsync(IList<Expression<Func<T, bool>>> lsWhere)
        {
            return await Repository.QueryAllAsync(lsWhere);
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
            return await Repository.QueryAllAsync(lsWhere, keySelector, asc);
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
            return await Repository.QueryAllAsync(where, keySelector, asc);
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
            return Repository.QueryPaging(page, size, out count);
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
            return Repository.QueryPaging(page, size, out count, keySelector, asc);
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
            return Repository.QueryPaging(page, size, out count, where);
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
            return Repository.QueryPaging(page, size, out count, lsWhere);
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
            return Repository.QueryPaging(page, size, out count, lsWhere, keySelector, asc);
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
            return Repository.QueryPaging(page, size, out count, where, keySelector, asc);
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
            return await Repository.QueryPagingAsync(page, size, recvTotalRecordsHandle);
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
            return await Repository.QueryPagingAsync(page, size, recvTotalRecordsHandle, keySelector, asc);
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
            return await Repository.QueryPagingAsync(page, size, recvTotalRecordsHandle, where);
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
            return await Repository.QueryPagingAsync(page, size, recvTotalRecordsHandle, lsWhere);
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
            return await Repository.QueryPagingAsync(page, size, recvTotalRecordsHandle, lsWhere, keySelector, asc);
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
            return await Repository.QueryPagingAsync(page, size, recvTotalRecordsHandle, where, keySelector, asc);
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
            return Repository.Add(entity);
        }

        /// <summary>
        /// Add1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Add1(T entity)
        {
            return Repository.AddAndReturn(entity);
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Add(IEnumerable<T> entities)
        {
            return Repository.Add(entities);
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
            return await Repository.AddAsync(entity);
        }

        /// <summary>
        /// Add1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<T> Add1Async(T entity)
        {
            return await Repository.AddAndReturnAsync(entity);
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> AddAsync(IEnumerable<T> entities)
        {
            return await Repository.AddAsync(entities);
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
            return Repository.Update(entity);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Update(IEnumerable<T> entities)
        {
            return Repository.Update(entities);
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
            return await Repository.UpdateAsync(entity);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> UpdateAsync(IEnumerable<T> entities)
        {
            return await Repository.UpdateAsync(entities);
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
            return Repository.Delete(entity);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual int Delete(IEnumerable<T> entities)
        {
            return Repository.Delete(entities);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual int Delete<TKey>(TKey id)
        {
            return Repository.Delete<TKey>(id);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual int Delete<TKey>(IEnumerable<TKey> ids)
        {
            return Repository.Delete<TKey>(ids);
        }
        #endregion


        #region Delete Async
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task<int> DeleteAsync(T entity)
        {
            return await Repository.DeleteAsync(entity);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task<int> DeleteAsync(IEnumerable<T> entities)
        {
            return await Repository.DeleteAsync(entities);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync<TKey>(TKey id)
        {
            return await Repository.DeleteAsync<TKey>(id);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync<TKey>(IEnumerable<TKey> ids)
        {
            return await Repository.DeleteAsync<TKey>(ids);
        }
        #endregion
        #endregion
    }
}
