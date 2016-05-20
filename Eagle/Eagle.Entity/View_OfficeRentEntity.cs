﻿
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2016年1月16日 15:13:36
    /// 作  者：陈卓
    /// 邮  箱：838010363@qq.com
    /// </summary>
    using Eagle.DBUtility;
    using Eagle.Interface;
    using System.Collections.Generic;
    using System.Reflection;
  
    namespace Eagle.Entity
    {
      /// <summary>
      /// 数据库表View_OfficeRent所对应的实体类
      /// </summary>
    public partial class View_OfficeRentEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {};
      #endregion

          #region 成员变量:_BuildingAddress
          private System.String _BuildingAddress;
          private bool _BuildingAddressChanged = false;
          CompareParam _BuildingAddressCompareParam = CompareParam.Equal;
          public string _BuildingAddressDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingId
          private System.Int32 _BuildingId;
          private bool _BuildingIdChanged = false;
          CompareParam _BuildingIdCompareParam = CompareParam.Equal;
          public string _BuildingIdDbType = "int";
          #endregion
  
          #region 成员变量:_BuildingName
          private System.String _BuildingName;
          private bool _BuildingNameChanged = false;
          CompareParam _BuildingNameCompareParam = CompareParam.Equal;
          public string _BuildingNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_CBDId
          private System.Int32 _CBDId;
          private bool _CBDIdChanged = false;
          CompareParam _CBDIdCompareParam = CompareParam.Equal;
          public string _CBDIdDbType = "int";
          #endregion
  
          #region 成员变量:_CBDName
          private System.String _CBDName;
          private bool _CBDNameChanged = false;
          CompareParam _CBDNameCompareParam = CompareParam.Equal;
          public string _CBDNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_CityId
          private System.Int32 _CityId;
          private bool _CityIdChanged = false;
          CompareParam _CityIdCompareParam = CompareParam.Equal;
          public string _CityIdDbType = "int";
          #endregion
  
          #region 成员变量:_CityName
          private System.String _CityName;
          private bool _CityNameChanged = false;
          CompareParam _CityNameCompareParam = CompareParam.Equal;
          public string _CityNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_CitySort
          private System.Int32 _CitySort;
          private bool _CitySortChanged = false;
          CompareParam _CitySortCompareParam = CompareParam.Equal;
          public string _CitySortDbType = "int";
          #endregion
  
          #region 成员变量:_Descri
          private System.String _Descri;
          private bool _DescriChanged = false;
          CompareParam _DescriCompareParam = CompareParam.Equal;
          public string _DescriDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DeveloperId
          private System.Int32 _DeveloperId;
          private bool _DeveloperIdChanged = false;
          CompareParam _DeveloperIdCompareParam = CompareParam.Equal;
          public string _DeveloperIdDbType = "int";
          #endregion
  
          #region 成员变量:_DisName
          private System.String _DisName;
          private bool _DisNameChanged = false;
          CompareParam _DisNameCompareParam = CompareParam.Equal;
          public string _DisNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DisSort
          private System.Int32 _DisSort;
          private bool _DisSortChanged = false;
          CompareParam _DisSortCompareParam = CompareParam.Equal;
          public string _DisSortDbType = "int";
          #endregion
  
          #region 成员变量:_DistrictId
          private System.Int32 _DistrictId;
          private bool _DistrictIdChanged = false;
          CompareParam _DistrictIdCompareParam = CompareParam.Equal;
          public string _DistrictIdDbType = "int";
          #endregion
  
          #region 成员变量:_Floor
          private System.Int32 _Floor;
          private bool _FloorChanged = false;
          CompareParam _FloorCompareParam = CompareParam.Equal;
          public string _FloorDbType = "int";
          #endregion
  
          #region 成员变量:_HitCount
          private System.Int32 _HitCount;
          private bool _HitCountChanged = false;
          CompareParam _HitCountCompareParam = CompareParam.Equal;
          public string _HitCountDbType = "int";
          #endregion
  
          #region 成员变量:_InputTime
          private System.DateTime _InputTime;
          private bool _InputTimeChanged = false;
          CompareParam _InputTimeCompareParam = CompareParam.Equal;
          public string _InputTimeDbType = "datetime";
          #endregion
  
          #region 成员变量:_IsDivision
          private System.Boolean _IsDivision;
          private bool _IsDivisionChanged = false;
          CompareParam _IsDivisionCompareParam = CompareParam.Equal;
          public string _IsDivisionDbType = "bit";
          #endregion
  
          #region 成员变量:_IsPropertyFees
          private System.Boolean _IsPropertyFees;
          private bool _IsPropertyFeesChanged = false;
          CompareParam _IsPropertyFeesCompareParam = CompareParam.Equal;
          public string _IsPropertyFeesDbType = "bit";
          #endregion
  
          #region 成员变量:_IsTemplate
          private System.Boolean _IsTemplate;
          private bool _IsTemplateChanged = false;
          CompareParam _IsTemplateCompareParam = CompareParam.Equal;
          public string _IsTemplateDbType = "bit";
          #endregion
  
          #region 成员变量:_OfficeRentId
          private System.Int32 _OfficeRentId;
          private bool _OfficeRentIdChanged = false;
          CompareParam _OfficeRentIdCompareParam = CompareParam.Equal;
          public string _OfficeRentIdDbType = "int";
          #endregion
  
          #region 成员变量:_OfficeRentName
          private System.String _OfficeRentName;
          private bool _OfficeRentNameChanged = false;
          CompareParam _OfficeRentNameCompareParam = CompareParam.Equal;
          public string _OfficeRentNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_PaymentMethodId
          private System.Int32 _PaymentMethodId;
          private bool _PaymentMethodIdChanged = false;
          CompareParam _PaymentMethodIdCompareParam = CompareParam.Equal;
          public string _PaymentMethodIdDbType = "int";
          #endregion
  
          #region 成员变量:_ProId
          private System.Int32 _ProId;
          private bool _ProIdChanged = false;
          CompareParam _ProIdCompareParam = CompareParam.Equal;
          public string _ProIdDbType = "int";
          #endregion
  
          #region 成员变量:_ProName
          private System.String _ProName;
          private bool _ProNameChanged = false;
          CompareParam _ProNameCompareParam = CompareParam.Equal;
          public string _ProNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_PropertyFees
          private System.Decimal _PropertyFees;
          private bool _PropertyFeesChanged = false;
          CompareParam _PropertyFeesCompareParam = CompareParam.Equal;
          public string _PropertyFeesDbType = "decimal";
          #endregion
  
          #region 成员变量:_PropertyId
          private System.Int32 _PropertyId;
          private bool _PropertyIdChanged = false;
          CompareParam _PropertyIdCompareParam = CompareParam.Equal;
          public string _PropertyIdDbType = "int";
          #endregion
  
          #region 成员变量:_ProRemark
          private System.String _ProRemark;
          private bool _ProRemarkChanged = false;
          CompareParam _ProRemarkCompareParam = CompareParam.Equal;
          public string _ProRemarkDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_ProSort
          private System.Int32 _ProSort;
          private bool _ProSortChanged = false;
          CompareParam _ProSortCompareParam = CompareParam.Equal;
          public string _ProSortDbType = "int";
          #endregion
  
          #region 成员变量:_RentPrice
          private System.Decimal _RentPrice;
          private bool _RentPriceChanged = false;
          CompareParam _RentPriceCompareParam = CompareParam.Equal;
          public string _RentPriceDbType = "decimal";
          #endregion
  
          #region 成员变量:_RoomNumber
          private System.String _RoomNumber;
          private bool _RoomNumberChanged = false;
          CompareParam _RoomNumberCompareParam = CompareParam.Equal;
          public string _RoomNumberDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_SquareFootage
          private System.String _SquareFootage;
          private bool _SquareFootageChanged = false;
          CompareParam _SquareFootageCompareParam = CompareParam.Equal;
          public string _SquareFootageDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UploadGroupId
          private System.Int32 _UploadGroupId;
          private bool _UploadGroupIdChanged = false;
          CompareParam _UploadGroupIdCompareParam = CompareParam.Equal;
          public string _UploadGroupIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserId
          private System.Int32 _UserId;
          private bool _UserIdChanged = false;
          CompareParam _UserIdCompareParam = CompareParam.Equal;
          public string _UserIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public View_OfficeRentEntity()
          {

          }
  
      /// <summary>
      /// 返回主键字段名数组
      ///</summary>
      ///<returns>返回主键字段名数组</returns>
      public string[] PrimaryKeys()
      {
        return _PrimaryKeys;
      }

        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingAddress
        {
          get { return _BuildingAddress; }
          set {
                _BuildingAddress = value;
                BuildingAddressChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingAddressChanged
        /// </summary>
        public bool BuildingAddressChanged
        {
          get { return _BuildingAddressChanged;}
          set {
                _BuildingAddressChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingAddressCompareParam
        /// </summary>
        public CompareParam BuildingAddressCompareParam
        {
          get { return _BuildingAddressCompareParam ;}
          set {
                _BuildingAddressCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingAddress的数据库存储类型
        /// </summary>
        public string BuildingAddressDbType
        {
          get { 
                return _BuildingAddressDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 BuildingId
        {
          get { return _BuildingId; }
          set {
                _BuildingId = value;
                BuildingIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingIdChanged
        /// </summary>
        public bool BuildingIdChanged
        {
          get { return _BuildingIdChanged;}
          set {
                _BuildingIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingIdCompareParam
        /// </summary>
        public CompareParam BuildingIdCompareParam
        {
          get { return _BuildingIdCompareParam ;}
          set {
                _BuildingIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingId的数据库存储类型
        /// </summary>
        public string BuildingIdDbType
        {
          get { 
                return _BuildingIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingName
        {
          get { return _BuildingName; }
          set {
                _BuildingName = value;
                BuildingNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingNameChanged
        /// </summary>
        public bool BuildingNameChanged
        {
          get { return _BuildingNameChanged;}
          set {
                _BuildingNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingNameCompareParam
        /// </summary>
        public CompareParam BuildingNameCompareParam
        {
          get { return _BuildingNameCompareParam ;}
          set {
                _BuildingNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingName的数据库存储类型
        /// </summary>
        public string BuildingNameDbType
        {
          get { 
                return _BuildingNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 CBDId
        {
          get { return _CBDId; }
          set {
                _CBDId = value;
                CBDIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CBDIdChanged
        /// </summary>
        public bool CBDIdChanged
        {
          get { return _CBDIdChanged;}
          set {
                _CBDIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CBDIdCompareParam
        /// </summary>
        public CompareParam CBDIdCompareParam
        {
          get { return _CBDIdCompareParam ;}
          set {
                _CBDIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CBDId的数据库存储类型
        /// </summary>
        public string CBDIdDbType
        {
          get { 
                return _CBDIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String CBDName
        {
          get { return _CBDName; }
          set {
                _CBDName = value;
                CBDNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CBDNameChanged
        /// </summary>
        public bool CBDNameChanged
        {
          get { return _CBDNameChanged;}
          set {
                _CBDNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CBDNameCompareParam
        /// </summary>
        public CompareParam CBDNameCompareParam
        {
          get { return _CBDNameCompareParam ;}
          set {
                _CBDNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CBDName的数据库存储类型
        /// </summary>
        public string CBDNameDbType
        {
          get { 
                return _CBDNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 CityId
        {
          get { return _CityId; }
          set {
                _CityId = value;
                CityIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CityIdChanged
        /// </summary>
        public bool CityIdChanged
        {
          get { return _CityIdChanged;}
          set {
                _CityIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CityIdCompareParam
        /// </summary>
        public CompareParam CityIdCompareParam
        {
          get { return _CityIdCompareParam ;}
          set {
                _CityIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CityId的数据库存储类型
        /// </summary>
        public string CityIdDbType
        {
          get { 
                return _CityIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String CityName
        {
          get { return _CityName; }
          set {
                _CityName = value;
                CityNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CityNameChanged
        /// </summary>
        public bool CityNameChanged
        {
          get { return _CityNameChanged;}
          set {
                _CityNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CityNameCompareParam
        /// </summary>
        public CompareParam CityNameCompareParam
        {
          get { return _CityNameCompareParam ;}
          set {
                _CityNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CityName的数据库存储类型
        /// </summary>
        public string CityNameDbType
        {
          get { 
                return _CityNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 CitySort
        {
          get { return _CitySort; }
          set {
                _CitySort = value;
                CitySortChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CitySortChanged
        /// </summary>
        public bool CitySortChanged
        {
          get { return _CitySortChanged;}
          set {
                _CitySortChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CitySortCompareParam
        /// </summary>
        public CompareParam CitySortCompareParam
        {
          get { return _CitySortCompareParam ;}
          set {
                _CitySortCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CitySort的数据库存储类型
        /// </summary>
        public string CitySortDbType
        {
          get { 
                return _CitySortDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String Descri
        {
          get { return _Descri; }
          set {
                _Descri = value;
                DescriChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DescriChanged
        /// </summary>
        public bool DescriChanged
        {
          get { return _DescriChanged;}
          set {
                _DescriChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DescriCompareParam
        /// </summary>
        public CompareParam DescriCompareParam
        {
          get { return _DescriCompareParam ;}
          set {
                _DescriCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Descri的数据库存储类型
        /// </summary>
        public string DescriDbType
        {
          get { 
                return _DescriDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 DeveloperId
        {
          get { return _DeveloperId; }
          set {
                _DeveloperId = value;
                DeveloperIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DeveloperIdChanged
        /// </summary>
        public bool DeveloperIdChanged
        {
          get { return _DeveloperIdChanged;}
          set {
                _DeveloperIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperIdCompareParam
        /// </summary>
        public CompareParam DeveloperIdCompareParam
        {
          get { return _DeveloperIdCompareParam ;}
          set {
                _DeveloperIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperId的数据库存储类型
        /// </summary>
        public string DeveloperIdDbType
        {
          get { 
                return _DeveloperIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String DisName
        {
          get { return _DisName; }
          set {
                _DisName = value;
                DisNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DisNameChanged
        /// </summary>
        public bool DisNameChanged
        {
          get { return _DisNameChanged;}
          set {
                _DisNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DisNameCompareParam
        /// </summary>
        public CompareParam DisNameCompareParam
        {
          get { return _DisNameCompareParam ;}
          set {
                _DisNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DisName的数据库存储类型
        /// </summary>
        public string DisNameDbType
        {
          get { 
                return _DisNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 DisSort
        {
          get { return _DisSort; }
          set {
                _DisSort = value;
                DisSortChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DisSortChanged
        /// </summary>
        public bool DisSortChanged
        {
          get { return _DisSortChanged;}
          set {
                _DisSortChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DisSortCompareParam
        /// </summary>
        public CompareParam DisSortCompareParam
        {
          get { return _DisSortCompareParam ;}
          set {
                _DisSortCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DisSort的数据库存储类型
        /// </summary>
        public string DisSortDbType
        {
          get { 
                return _DisSortDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 DistrictId
        {
          get { return _DistrictId; }
          set {
                _DistrictId = value;
                DistrictIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DistrictIdChanged
        /// </summary>
        public bool DistrictIdChanged
        {
          get { return _DistrictIdChanged;}
          set {
                _DistrictIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DistrictIdCompareParam
        /// </summary>
        public CompareParam DistrictIdCompareParam
        {
          get { return _DistrictIdCompareParam ;}
          set {
                _DistrictIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DistrictId的数据库存储类型
        /// </summary>
        public string DistrictIdDbType
        {
          get { 
                return _DistrictIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 Floor
        {
          get { return _Floor; }
          set {
                _Floor = value;
                FloorChanged=true;
              }
        }

        /// <summary>
        /// 属性: _FloorChanged
        /// </summary>
        public bool FloorChanged
        {
          get { return _FloorChanged;}
          set {
                _FloorChanged=value;
              }
        }

        /// <summary>
        /// 属性: _FloorCompareParam
        /// </summary>
        public CompareParam FloorCompareParam
        {
          get { return _FloorCompareParam ;}
          set {
                _FloorCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Floor的数据库存储类型
        /// </summary>
        public string FloorDbType
        {
          get { 
                return _FloorDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 HitCount
        {
          get { return _HitCount; }
          set {
                _HitCount = value;
                HitCountChanged=true;
              }
        }

        /// <summary>
        /// 属性: _HitCountChanged
        /// </summary>
        public bool HitCountChanged
        {
          get { return _HitCountChanged;}
          set {
                _HitCountChanged=value;
              }
        }

        /// <summary>
        /// 属性: _HitCountCompareParam
        /// </summary>
        public CompareParam HitCountCompareParam
        {
          get { return _HitCountCompareParam ;}
          set {
                _HitCountCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _HitCount的数据库存储类型
        /// </summary>
        public string HitCountDbType
        {
          get { 
                return _HitCountDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.DateTime InputTime
        {
          get { return _InputTime; }
          set {
                _InputTime = value;
                InputTimeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _InputTimeChanged
        /// </summary>
        public bool InputTimeChanged
        {
          get { return _InputTimeChanged;}
          set {
                _InputTimeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _InputTimeCompareParam
        /// </summary>
        public CompareParam InputTimeCompareParam
        {
          get { return _InputTimeCompareParam ;}
          set {
                _InputTimeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _InputTime的数据库存储类型
        /// </summary>
        public string InputTimeDbType
        {
          get { 
                return _InputTimeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Boolean IsDivision
        {
          get { return _IsDivision; }
          set {
                _IsDivision = value;
                IsDivisionChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsDivisionChanged
        /// </summary>
        public bool IsDivisionChanged
        {
          get { return _IsDivisionChanged;}
          set {
                _IsDivisionChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsDivisionCompareParam
        /// </summary>
        public CompareParam IsDivisionCompareParam
        {
          get { return _IsDivisionCompareParam ;}
          set {
                _IsDivisionCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsDivision的数据库存储类型
        /// </summary>
        public string IsDivisionDbType
        {
          get { 
                return _IsDivisionDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Boolean IsPropertyFees
        {
          get { return _IsPropertyFees; }
          set {
                _IsPropertyFees = value;
                IsPropertyFeesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsPropertyFeesChanged
        /// </summary>
        public bool IsPropertyFeesChanged
        {
          get { return _IsPropertyFeesChanged;}
          set {
                _IsPropertyFeesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsPropertyFeesCompareParam
        /// </summary>
        public CompareParam IsPropertyFeesCompareParam
        {
          get { return _IsPropertyFeesCompareParam ;}
          set {
                _IsPropertyFeesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsPropertyFees的数据库存储类型
        /// </summary>
        public string IsPropertyFeesDbType
        {
          get { 
                return _IsPropertyFeesDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Boolean IsTemplate
        {
          get { return _IsTemplate; }
          set {
                _IsTemplate = value;
                IsTemplateChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsTemplateChanged
        /// </summary>
        public bool IsTemplateChanged
        {
          get { return _IsTemplateChanged;}
          set {
                _IsTemplateChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsTemplateCompareParam
        /// </summary>
        public CompareParam IsTemplateCompareParam
        {
          get { return _IsTemplateCompareParam ;}
          set {
                _IsTemplateCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsTemplate的数据库存储类型
        /// </summary>
        public string IsTemplateDbType
        {
          get { 
                return _IsTemplateDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 OfficeRentId
        {
          get { return _OfficeRentId; }
          set {
                _OfficeRentId = value;
                OfficeRentIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentIdChanged
        /// </summary>
        public bool OfficeRentIdChanged
        {
          get { return _OfficeRentIdChanged;}
          set {
                _OfficeRentIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentIdCompareParam
        /// </summary>
        public CompareParam OfficeRentIdCompareParam
        {
          get { return _OfficeRentIdCompareParam ;}
          set {
                _OfficeRentIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentId的数据库存储类型
        /// </summary>
        public string OfficeRentIdDbType
        {
          get { 
                return _OfficeRentIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String OfficeRentName
        {
          get { return _OfficeRentName; }
          set {
                _OfficeRentName = value;
                OfficeRentNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentNameChanged
        /// </summary>
        public bool OfficeRentNameChanged
        {
          get { return _OfficeRentNameChanged;}
          set {
                _OfficeRentNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentNameCompareParam
        /// </summary>
        public CompareParam OfficeRentNameCompareParam
        {
          get { return _OfficeRentNameCompareParam ;}
          set {
                _OfficeRentNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentName的数据库存储类型
        /// </summary>
        public string OfficeRentNameDbType
        {
          get { 
                return _OfficeRentNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 PaymentMethodId
        {
          get { return _PaymentMethodId; }
          set {
                _PaymentMethodId = value;
                PaymentMethodIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodIdChanged
        /// </summary>
        public bool PaymentMethodIdChanged
        {
          get { return _PaymentMethodIdChanged;}
          set {
                _PaymentMethodIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodIdCompareParam
        /// </summary>
        public CompareParam PaymentMethodIdCompareParam
        {
          get { return _PaymentMethodIdCompareParam ;}
          set {
                _PaymentMethodIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodId的数据库存储类型
        /// </summary>
        public string PaymentMethodIdDbType
        {
          get { 
                return _PaymentMethodIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 ProId
        {
          get { return _ProId; }
          set {
                _ProId = value;
                ProIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProIdChanged
        /// </summary>
        public bool ProIdChanged
        {
          get { return _ProIdChanged;}
          set {
                _ProIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProIdCompareParam
        /// </summary>
        public CompareParam ProIdCompareParam
        {
          get { return _ProIdCompareParam ;}
          set {
                _ProIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProId的数据库存储类型
        /// </summary>
        public string ProIdDbType
        {
          get { 
                return _ProIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String ProName
        {
          get { return _ProName; }
          set {
                _ProName = value;
                ProNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProNameChanged
        /// </summary>
        public bool ProNameChanged
        {
          get { return _ProNameChanged;}
          set {
                _ProNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProNameCompareParam
        /// </summary>
        public CompareParam ProNameCompareParam
        {
          get { return _ProNameCompareParam ;}
          set {
                _ProNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProName的数据库存储类型
        /// </summary>
        public string ProNameDbType
        {
          get { 
                return _ProNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Decimal PropertyFees
        {
          get { return _PropertyFees; }
          set {
                _PropertyFees = value;
                PropertyFeesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyFeesChanged
        /// </summary>
        public bool PropertyFeesChanged
        {
          get { return _PropertyFeesChanged;}
          set {
                _PropertyFeesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyFeesCompareParam
        /// </summary>
        public CompareParam PropertyFeesCompareParam
        {
          get { return _PropertyFeesCompareParam ;}
          set {
                _PropertyFeesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyFees的数据库存储类型
        /// </summary>
        public string PropertyFeesDbType
        {
          get { 
                return _PropertyFeesDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 PropertyId
        {
          get { return _PropertyId; }
          set {
                _PropertyId = value;
                PropertyIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyIdChanged
        /// </summary>
        public bool PropertyIdChanged
        {
          get { return _PropertyIdChanged;}
          set {
                _PropertyIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyIdCompareParam
        /// </summary>
        public CompareParam PropertyIdCompareParam
        {
          get { return _PropertyIdCompareParam ;}
          set {
                _PropertyIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyId的数据库存储类型
        /// </summary>
        public string PropertyIdDbType
        {
          get { 
                return _PropertyIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String ProRemark
        {
          get { return _ProRemark; }
          set {
                _ProRemark = value;
                ProRemarkChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProRemarkChanged
        /// </summary>
        public bool ProRemarkChanged
        {
          get { return _ProRemarkChanged;}
          set {
                _ProRemarkChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProRemarkCompareParam
        /// </summary>
        public CompareParam ProRemarkCompareParam
        {
          get { return _ProRemarkCompareParam ;}
          set {
                _ProRemarkCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProRemark的数据库存储类型
        /// </summary>
        public string ProRemarkDbType
        {
          get { 
                return _ProRemarkDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 ProSort
        {
          get { return _ProSort; }
          set {
                _ProSort = value;
                ProSortChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProSortChanged
        /// </summary>
        public bool ProSortChanged
        {
          get { return _ProSortChanged;}
          set {
                _ProSortChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProSortCompareParam
        /// </summary>
        public CompareParam ProSortCompareParam
        {
          get { return _ProSortCompareParam ;}
          set {
                _ProSortCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProSort的数据库存储类型
        /// </summary>
        public string ProSortDbType
        {
          get { 
                return _ProSortDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Decimal RentPrice
        {
          get { return _RentPrice; }
          set {
                _RentPrice = value;
                RentPriceChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RentPriceChanged
        /// </summary>
        public bool RentPriceChanged
        {
          get { return _RentPriceChanged;}
          set {
                _RentPriceChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RentPriceCompareParam
        /// </summary>
        public CompareParam RentPriceCompareParam
        {
          get { return _RentPriceCompareParam ;}
          set {
                _RentPriceCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RentPrice的数据库存储类型
        /// </summary>
        public string RentPriceDbType
        {
          get { 
                return _RentPriceDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String RoomNumber
        {
          get { return _RoomNumber; }
          set {
                _RoomNumber = value;
                RoomNumberChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RoomNumberChanged
        /// </summary>
        public bool RoomNumberChanged
        {
          get { return _RoomNumberChanged;}
          set {
                _RoomNumberChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RoomNumberCompareParam
        /// </summary>
        public CompareParam RoomNumberCompareParam
        {
          get { return _RoomNumberCompareParam ;}
          set {
                _RoomNumberCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RoomNumber的数据库存储类型
        /// </summary>
        public string RoomNumberDbType
        {
          get { 
                return _RoomNumberDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String SquareFootage
        {
          get { return _SquareFootage; }
          set {
                _SquareFootage = value;
                SquareFootageChanged=true;
              }
        }

        /// <summary>
        /// 属性: _SquareFootageChanged
        /// </summary>
        public bool SquareFootageChanged
        {
          get { return _SquareFootageChanged;}
          set {
                _SquareFootageChanged=value;
              }
        }

        /// <summary>
        /// 属性: _SquareFootageCompareParam
        /// </summary>
        public CompareParam SquareFootageCompareParam
        {
          get { return _SquareFootageCompareParam ;}
          set {
                _SquareFootageCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _SquareFootage的数据库存储类型
        /// </summary>
        public string SquareFootageDbType
        {
          get { 
                return _SquareFootageDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 UploadGroupId
        {
          get { return _UploadGroupId; }
          set {
                _UploadGroupId = value;
                UploadGroupIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupIdChanged
        /// </summary>
        public bool UploadGroupIdChanged
        {
          get { return _UploadGroupIdChanged;}
          set {
                _UploadGroupIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupIdCompareParam
        /// </summary>
        public CompareParam UploadGroupIdCompareParam
        {
          get { return _UploadGroupIdCompareParam ;}
          set {
                _UploadGroupIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupId的数据库存储类型
        /// </summary>
        public string UploadGroupIdDbType
        {
          get { 
                return _UploadGroupIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 UserId
        {
          get { return _UserId; }
          set {
                _UserId = value;
                UserIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserIdChanged
        /// </summary>
        public bool UserIdChanged
        {
          get { return _UserIdChanged;}
          set {
                _UserIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserIdCompareParam
        /// </summary>
        public CompareParam UserIdCompareParam
        {
          get { return _UserIdCompareParam ;}
          set {
                _UserIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserId的数据库存储类型
        /// </summary>
        public string UserIdDbType
        {
          get { 
                return _UserIdDbType;
              }
        }
  
        /// <summary>
        /// 返回主键字段PropertyInfo集合
        /// </summary>
        /// PropertyInfo集合
        public List<PropertyInfo> GetPrimaryKeys()
        {
              List<PropertyInfo> RetList = new List<PropertyInfo>();
              if(_PrimaryKeys==null||_PrimaryKeys.Length==0)
              {
              return RetList;
              }
              foreach(string key in _PrimaryKeys)
              {
                  RetList.Add(this.GetType().GetProperty(key));
              }
              return RetList;
         }
  
  }
     }
  