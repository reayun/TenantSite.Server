﻿using AlonsoAdmin.Services.Dictionary.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlonsoAdmin.Services.Dictionary.Interface
{
    /// <summary>
    /// 字典主表服务接口类
    /// </summary>
    public interface IDictionaryEntryService
        : IBaseService<
            DictionaryEntryFilterRequest, // 查询对象实体 DTO
            DictionaryEntryAddRequest,    // 新增对象实体 DTO
            DictionaryEntryEditRequest    // 编辑对象实体 DTO
            >
    {
        #region 特殊接口 (常规接口在IBaseService中已定义)
        // 定义特殊接口
        #endregion 
    }
}