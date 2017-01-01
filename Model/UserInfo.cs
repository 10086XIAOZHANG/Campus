using System;
namespace CP.Campus.Model
{
	/// <summary>
	/// UserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region Model
		private string _userid;
		private string _username;
		private string _sex;
		private string _birthday;
		private string _email;
		private string _qq;
		private string _phonenumber;
		private string _usertype;
		private string _hobby;
		private string _motto;
        private string _photoaddress;
		/// <summary>
		/// 
		/// </summary>
		public string userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phoneNumber
		{
			set{ _phonenumber=value;}
			get{return _phonenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hobby
		{
			set{ _hobby=value;}
			get{return _hobby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string motto
		{
			set{ _motto=value;}
			get{return _motto;}
		}
        public string photoAddress
        {
            set { _photoaddress = value; }
            get { return _photoaddress; }
        }
		#endregion Model

	}
}

