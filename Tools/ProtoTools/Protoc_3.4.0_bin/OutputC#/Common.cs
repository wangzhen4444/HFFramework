// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: common.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Centersdk.Protobuf {

  #region Messages
  /// <summary>
  ///通用数组参数类
  /// </summary>
  public sealed class ParamsArray : pb::IMessage {
    private static readonly pb::MessageParser<ParamsArray> _parser = new pb::MessageParser<ParamsArray>(() => new ParamsArray());
    public static pb::MessageParser<ParamsArray> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::Centersdk.Protobuf.Params> _repeated_params_codec
        = pb::FieldCodec.ForMessage(10, global::Centersdk.Protobuf.Params.Parser);
    private pbc::RepeatedField<global::Centersdk.Protobuf.Params> params_ = new pbc::RepeatedField<global::Centersdk.Protobuf.Params>();
    public pbc::RepeatedField<global::Centersdk.Protobuf.Params> Params {
      get { return params_; }
      set {
        params_ = value;
      }
    }

    private global::Centersdk.Protobuf.Params param_;
    public global::Centersdk.Protobuf.Params Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    private int code_;
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    private int type_;
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      params_.WriteTo(output, _repeated_params_codec);
      if (param_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Param);
      }
      if (Code != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Code);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Type);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += params_.CalculateSize(_repeated_params_codec);
      if (param_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Param);
      }
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            params_.AddEntriesFrom(input, _repeated_params_codec);
            break;
          }
          case 18: {
            if (param_ == null) {
              param_ = new global::Centersdk.Protobuf.Params();
            }
            input.ReadMessage(param_);
            break;
          }
          case 24: {
            Code = input.ReadInt32();
            break;
          }
          case 32: {
            Type = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///通用参数类。此类目的。避免重复定义VO
  /// </summary>
  public sealed class Params : pb::IMessage {
    private static readonly pb::MessageParser<Params> _parser = new pb::MessageParser<Params>(() => new Params());
    public static pb::MessageParser<Params> Parser { get { return _parser; } }

    private long userId_;
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    private long roleId_;
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    private int code_;
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    private int count_;
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    private long amount_;
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    private int value_;
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    private int index_;
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    private int status_;
    public int Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    private bool statusB_;
    public bool StatusB {
      get { return statusB_; }
      set {
        statusB_ = value;
      }
    }

    private int type_;
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    private int itemId_;
    public int ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    private int gold_;
    public int Gold {
      get { return gold_; }
      set {
        gold_ = value;
      }
    }

    private long time_;
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    private string text_ = "";
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string content_ = "";
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private static readonly pb::FieldCodec<long> _repeated_userIds_codec
        = pb::FieldCodec.ForInt64(138);
    private pbc::RepeatedField<long> userIds_ = new pbc::RepeatedField<long>();
    /// <summary>
    ///用户ID数组
    /// </summary>
    public pbc::RepeatedField<long> UserIds {
      get { return userIds_; }
      set {
        userIds_ = value;
      }
    }

    private static readonly pb::FieldCodec<int> _repeated_intVals_codec
        = pb::FieldCodec.ForInt32(146);
    private pbc::RepeatedField<int> intVals_ = new pbc::RepeatedField<int>();
    /// <summary>
    ///整形数组参数
    /// </summary>
    public pbc::RepeatedField<int> IntVals {
      get { return intVals_; }
      set {
        intVals_ = value;
      }
    }

    private static readonly pb::FieldCodec<long> _repeated_longVals_codec
        = pb::FieldCodec.ForInt64(154);
    private pbc::RepeatedField<long> longVals_ = new pbc::RepeatedField<long>();
    /// <summary>
    ///长整型数组参数
    /// </summary>
    public pbc::RepeatedField<long> LongVals {
      get { return longVals_; }
      set {
        longVals_ = value;
      }
    }

    private static readonly pb::FieldCodec<string> _repeated_strVals_codec
        = pb::FieldCodec.ForString(162);
    private pbc::RepeatedField<string> strVals_ = new pbc::RepeatedField<string>();
    /// <summary>
    ///字符数组参数
    /// </summary>
    public pbc::RepeatedField<string> StrVals {
      get { return strVals_; }
      set {
        strVals_ = value;
      }
    }

    private static readonly pb::FieldCodec<float> _repeated_floatVals_codec
        = pb::FieldCodec.ForFloat(170);
    private pbc::RepeatedField<float> floatVals_ = new pbc::RepeatedField<float>();
    /// <summary>
    ///float类型参数
    /// </summary>
    public pbc::RepeatedField<float> FloatVals {
      get { return floatVals_; }
      set {
        floatVals_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      if (RoleId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RoleId);
      }
      if (Id != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Id);
      }
      if (Code != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Code);
      }
      if (Count != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Count);
      }
      if (Amount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Amount);
      }
      if (Value != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Value);
      }
      if (Index != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Index);
      }
      if (Status != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Status);
      }
      if (StatusB != false) {
        output.WriteRawTag(80);
        output.WriteBool(StatusB);
      }
      if (Type != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Type);
      }
      if (ItemId != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(ItemId);
      }
      if (Gold != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Gold);
      }
      if (Time != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(Time);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(Text);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(Content);
      }
      userIds_.WriteTo(output, _repeated_userIds_codec);
      intVals_.WriteTo(output, _repeated_intVals_codec);
      longVals_.WriteTo(output, _repeated_longVals_codec);
      strVals_.WriteTo(output, _repeated_strVals_codec);
      floatVals_.WriteTo(output, _repeated_floatVals_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Amount);
      }
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
      }
      if (StatusB != false) {
        size += 1 + 1;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemId);
      }
      if (Gold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gold);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (Content.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      size += userIds_.CalculateSize(_repeated_userIds_codec);
      size += intVals_.CalculateSize(_repeated_intVals_codec);
      size += longVals_.CalculateSize(_repeated_longVals_codec);
      size += strVals_.CalculateSize(_repeated_strVals_codec);
      size += floatVals_.CalculateSize(_repeated_floatVals_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
          case 16: {
            RoleId = input.ReadInt64();
            break;
          }
          case 24: {
            Id = input.ReadInt32();
            break;
          }
          case 32: {
            Code = input.ReadInt32();
            break;
          }
          case 40: {
            Count = input.ReadInt32();
            break;
          }
          case 48: {
            Amount = input.ReadInt64();
            break;
          }
          case 56: {
            Value = input.ReadInt32();
            break;
          }
          case 64: {
            Index = input.ReadInt32();
            break;
          }
          case 72: {
            Status = input.ReadInt32();
            break;
          }
          case 80: {
            StatusB = input.ReadBool();
            break;
          }
          case 88: {
            Type = input.ReadInt32();
            break;
          }
          case 96: {
            ItemId = input.ReadInt32();
            break;
          }
          case 104: {
            Gold = input.ReadInt32();
            break;
          }
          case 112: {
            Time = input.ReadInt64();
            break;
          }
          case 122: {
            Text = input.ReadString();
            break;
          }
          case 130: {
            Content = input.ReadString();
            break;
          }
          case 138:
          case 136: {
            userIds_.AddEntriesFrom(input, _repeated_userIds_codec);
            break;
          }
          case 146:
          case 144: {
            intVals_.AddEntriesFrom(input, _repeated_intVals_codec);
            break;
          }
          case 154:
          case 152: {
            longVals_.AddEntriesFrom(input, _repeated_longVals_codec);
            break;
          }
          case 162: {
            strVals_.AddEntriesFrom(input, _repeated_strVals_codec);
            break;
          }
          case 170:
          case 173: {
            floatVals_.AddEntriesFrom(input, _repeated_floatVals_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class Empty : pb::IMessage {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  /// 服务器之间跳转时使用
  /// </summary>
  public sealed class QuickLoginInfo : pb::IMessage {
    private static readonly pb::MessageParser<QuickLoginInfo> _parser = new pb::MessageParser<QuickLoginInfo>(() => new QuickLoginInfo());
    public static pb::MessageParser<QuickLoginInfo> Parser { get { return _parser; } }

    private long userId_;
    /// <summary>
    /// 玩家ID
    /// </summary>
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    private long roleId_;
    /// <summary>
    /// 角色ID
    /// </summary>
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    private long key_;
    /// <summary>
    /// 登录key
    /// </summary>
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    private string serverId_ = "";
    /// <summary>
    /// 服务器ID
    /// </summary>
    public string ServerId {
      get { return serverId_; }
      set {
        serverId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string ip_ = "";
    /// <summary>
    /// 服务器域名
    /// </summary>
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private int port_;
    /// <summary>
    /// 服务器端口
    /// </summary>
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    private string type_ = "";
    /// <summary>
    /// 服务器类别
    /// </summary>
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string param_ = "";
    /// <summary>
    /// 特有参数，一般由子服务器和前端协商定义。建议使用json格式。方便拓展
    /// </summary>
    public string Param {
      get { return param_; }
      set {
        param_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private int code_;
    /// <summary>
    /// 消息码，前后端协商定义
    /// </summary>
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    private string groupId_ = "";
    /// <summary>
    /// 玩法的分类ID
    /// </summary>
    public string GroupId {
      get { return groupId_; }
      set {
        groupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string version_ = "";
    /// <summary>
    /// 用户登录版本号
    /// </summary>
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private long roomId_;
    /// <summary>
    /// 房间ID
    /// </summary>
    public long RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      if (RoleId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RoleId);
      }
      if (Key != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Key);
      }
      if (ServerId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ServerId);
      }
      if (Ip.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Ip);
      }
      if (Port != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Port);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Type);
      }
      if (Param.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Param);
      }
      if (Code != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Code);
      }
      if (GroupId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(GroupId);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Version);
      }
      if (RoomId != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(RoomId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      if (ServerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerId);
      }
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Param.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Param);
      }
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (GroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupId);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (RoomId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoomId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
          case 16: {
            RoleId = input.ReadInt64();
            break;
          }
          case 24: {
            Key = input.ReadInt64();
            break;
          }
          case 34: {
            ServerId = input.ReadString();
            break;
          }
          case 42: {
            Ip = input.ReadString();
            break;
          }
          case 48: {
            Port = input.ReadInt32();
            break;
          }
          case 58: {
            Type = input.ReadString();
            break;
          }
          case 66: {
            Param = input.ReadString();
            break;
          }
          case 72: {
            Code = input.ReadInt32();
            break;
          }
          case 82: {
            GroupId = input.ReadString();
            break;
          }
          case 90: {
            Version = input.ReadString();
            break;
          }
          case 96: {
            RoomId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// int数组
  /// </summary>
  public sealed class IntegerValues : pb::IMessage {
    private static readonly pb::MessageParser<IntegerValues> _parser = new pb::MessageParser<IntegerValues>(() => new IntegerValues());
    public static pb::MessageParser<IntegerValues> Parser { get { return _parser; } }

    private int id_;
    /// <summary>
    /// id
    /// </summary>
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    private static readonly pb::FieldCodec<int> _repeated_vals_codec
        = pb::FieldCodec.ForInt32(18);
    private pbc::RepeatedField<int> vals_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// 整数数组参数
    /// </summary>
    public pbc::RepeatedField<int> Vals {
      get { return vals_; }
      set {
        vals_ = value;
      }
    }

    private int val1_;
    /// <summary>
    /// 扩展参数1
    /// </summary>
    public int Val1 {
      get { return val1_; }
      set {
        val1_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      vals_.WriteTo(output, _repeated_vals_codec);
      if (Val1 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Val1);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      size += vals_.CalculateSize(_repeated_vals_codec);
      if (Val1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Val1);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            vals_.AddEntriesFrom(input, _repeated_vals_codec);
            break;
          }
          case 24: {
            Val1 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class IntegerValue : pb::IMessage {
    private static readonly pb::MessageParser<IntegerValue> _parser = new pb::MessageParser<IntegerValue>(() => new IntegerValue());
    public static pb::MessageParser<IntegerValue> Parser { get { return _parser; } }

    private int val_;
    /// <summary>
    /// 整型参数
    /// </summary>
    public int Val {
      get { return val_; }
      set {
        val_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Val != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Val);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Val != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Val);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Val = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 长整型参数
  /// </summary>
  public sealed class LongValue : pb::IMessage {
    private static readonly pb::MessageParser<LongValue> _parser = new pb::MessageParser<LongValue>(() => new LongValue());
    public static pb::MessageParser<LongValue> Parser { get { return _parser; } }

    private long val_;
    public long Val {
      get { return val_; }
      set {
        val_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Val != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Val);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Val != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Val);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Val = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed class LongValues : pb::IMessage {
    private static readonly pb::MessageParser<LongValues> _parser = new pb::MessageParser<LongValues>(() => new LongValues());
    public static pb::MessageParser<LongValues> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<long> _repeated_vals_codec
        = pb::FieldCodec.ForInt64(10);
    private pbc::RepeatedField<long> vals_ = new pbc::RepeatedField<long>();
    public pbc::RepeatedField<long> Vals {
      get { return vals_; }
      set {
        vals_ = value;
      }
    }

    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    private int val1_;
    /// <summary>
    /// int类型扩展参数1
    /// </summary>
    public int Val1 {
      get { return val1_; }
      set {
        val1_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      vals_.WriteTo(output, _repeated_vals_codec);
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      if (Val1 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Val1);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += vals_.CalculateSize(_repeated_vals_codec);
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Val1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Val1);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            vals_.AddEntriesFrom(input, _repeated_vals_codec);
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 24: {
            Val1 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class TwoIntegerValue : pb::IMessage {
    private static readonly pb::MessageParser<TwoIntegerValue> _parser = new pb::MessageParser<TwoIntegerValue>(() => new TwoIntegerValue());
    public static pb::MessageParser<TwoIntegerValue> Parser { get { return _parser; } }

    private int intVal1_;
    public int IntVal1 {
      get { return intVal1_; }
      set {
        intVal1_ = value;
      }
    }

    private int intVal2_;
    public int IntVal2 {
      get { return intVal2_; }
      set {
        intVal2_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (IntVal1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntVal1);
      }
      if (IntVal2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(IntVal2);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (IntVal1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntVal1);
      }
      if (IntVal2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntVal2);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IntVal1 = input.ReadInt32();
            break;
          }
          case 16: {
            IntVal2 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class TwoIntegerValues : pb::IMessage {
    private static readonly pb::MessageParser<TwoIntegerValues> _parser = new pb::MessageParser<TwoIntegerValues>(() => new TwoIntegerValues());
    public static pb::MessageParser<TwoIntegerValues> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::Centersdk.Protobuf.TwoIntegerValue> _repeated_vals_codec
        = pb::FieldCodec.ForMessage(10, global::Centersdk.Protobuf.TwoIntegerValue.Parser);
    private pbc::RepeatedField<global::Centersdk.Protobuf.TwoIntegerValue> vals_ = new pbc::RepeatedField<global::Centersdk.Protobuf.TwoIntegerValue>();
    public pbc::RepeatedField<global::Centersdk.Protobuf.TwoIntegerValue> Vals {
      get { return vals_; }
      set {
        vals_ = value;
      }
    }

    private int intVal1_;
    public int IntVal1 {
      get { return intVal1_; }
      set {
        intVal1_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      vals_.WriteTo(output, _repeated_vals_codec);
      if (IntVal1 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(IntVal1);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += vals_.CalculateSize(_repeated_vals_codec);
      if (IntVal1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntVal1);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            vals_.AddEntriesFrom(input, _repeated_vals_codec);
            break;
          }
          case 16: {
            IntVal1 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 两个整型和一个长整型
  /// </summary>
  public sealed class TwoIntegerAndLongValue : pb::IMessage {
    private static readonly pb::MessageParser<TwoIntegerAndLongValue> _parser = new pb::MessageParser<TwoIntegerAndLongValue>(() => new TwoIntegerAndLongValue());
    public static pb::MessageParser<TwoIntegerAndLongValue> Parser { get { return _parser; } }

    private long longVal_;
    public long LongVal {
      get { return longVal_; }
      set {
        longVal_ = value;
      }
    }

    private int intVal1_;
    public int IntVal1 {
      get { return intVal1_; }
      set {
        intVal1_ = value;
      }
    }

    private int intVal2_;
    public int IntVal2 {
      get { return intVal2_; }
      set {
        intVal2_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (LongVal != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(LongVal);
      }
      if (IntVal1 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(IntVal1);
      }
      if (IntVal2 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(IntVal2);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (LongVal != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LongVal);
      }
      if (IntVal1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntVal1);
      }
      if (IntVal2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntVal2);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            LongVal = input.ReadInt64();
            break;
          }
          case 16: {
            IntVal1 = input.ReadInt32();
            break;
          }
          case 24: {
            IntVal2 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class StringValue : pb::IMessage {
    private static readonly pb::MessageParser<StringValue> _parser = new pb::MessageParser<StringValue>(() => new StringValue());
    public static pb::MessageParser<StringValue> Parser { get { return _parser; } }

    private string val_ = "";
    /// <summary>
    /// 字符串参数
    /// </summary>
    public string Val {
      get { return val_; }
      set {
        val_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Val.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Val);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Val.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Val);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Val = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed class FloatValue : pb::IMessage {
    private static readonly pb::MessageParser<FloatValue> _parser = new pb::MessageParser<FloatValue>(() => new FloatValue());
    public static pb::MessageParser<FloatValue> Parser { get { return _parser; } }

    private float val_;
    /// <summary>
    /// float参数
    /// </summary>
    public float Val {
      get { return val_; }
      set {
        val_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Val != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Val);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Val != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            Val = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed class StringValues : pb::IMessage {
    private static readonly pb::MessageParser<StringValues> _parser = new pb::MessageParser<StringValues>(() => new StringValues());
    public static pb::MessageParser<StringValues> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<string> _repeated_vals_codec
        = pb::FieldCodec.ForString(10);
    private pbc::RepeatedField<string> vals_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// 字符数组参数
    /// </summary>
    public pbc::RepeatedField<string> Vals {
      get { return vals_; }
      set {
        vals_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      vals_.WriteTo(output, _repeated_vals_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += vals_.CalculateSize(_repeated_vals_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            vals_.AddEntriesFrom(input, _repeated_vals_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class Status : pb::IMessage {
    private static readonly pb::MessageParser<Status> _parser = new pb::MessageParser<Status>(() => new Status());
    public static pb::MessageParser<Status> Parser { get { return _parser; } }

    private int code_;
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Code = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code