// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: friend.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Centersdk.Protobuf {

  #region Messages
  /// <summary>
  ///好友列表
  /// </summary>
  public sealed class FriendArray : pb::IMessage {
    private static readonly pb::MessageParser<FriendArray> _parser = new pb::MessageParser<FriendArray>(() => new FriendArray());
    public static pb::MessageParser<FriendArray> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::Centersdk.Protobuf.FriendInfo> _repeated_friends_codec
        = pb::FieldCodec.ForMessage(10, global::Centersdk.Protobuf.FriendInfo.Parser);
    private pbc::RepeatedField<global::Centersdk.Protobuf.FriendInfo> friends_ = new pbc::RepeatedField<global::Centersdk.Protobuf.FriendInfo>();
    public pbc::RepeatedField<global::Centersdk.Protobuf.FriendInfo> Friends {
      get { return friends_; }
      set {
        friends_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      friends_.WriteTo(output, _repeated_friends_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += friends_.CalculateSize(_repeated_friends_codec);
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
            friends_.AddEntriesFrom(input, _repeated_friends_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///好友信息
  /// </summary>
  public sealed class FriendInfo : pb::IMessage {
    private static readonly pb::MessageParser<FriendInfo> _parser = new pb::MessageParser<FriendInfo>(() => new FriendInfo());
    public static pb::MessageParser<FriendInfo> Parser { get { return _parser; } }

    private long roleId_;
    /// <summary>
    /// 全局唯一角色ID
    /// </summary>
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    private string name_ = "";
    /// <summary>
    /// 角色名称
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private int type_;
    /// <summary>
    /// 角色类型
    /// </summary>
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    private int level_;
    /// <summary>
    /// 角色等级
    /// </summary>
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    private int sex_;
    /// <summary>
    /// 性别
    /// </summary>
    public int Sex {
      get { return sex_; }
      set {
        sex_ = value;
      }
    }

    private int headImgId_;
    /// <summary>
    /// 头像ID
    /// </summary>
    public int HeadImgId {
      get { return headImgId_; }
      set {
        headImgId_ = value;
      }
    }

    private int goodFeel_;
    /// <summary>
    /// 好感度
    /// </summary>
    public int GoodFeel {
      get { return goodFeel_; }
      set {
        goodFeel_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RoleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoleId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Type);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Level);
      }
      if (Sex != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Sex);
      }
      if (HeadImgId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(HeadImgId);
      }
      if (GoodFeel != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(GoodFeel);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Sex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Sex);
      }
      if (HeadImgId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HeadImgId);
      }
      if (GoodFeel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GoodFeel);
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
            RoleId = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Type = input.ReadInt32();
            break;
          }
          case 32: {
            Level = input.ReadInt32();
            break;
          }
          case 40: {
            Sex = input.ReadInt32();
            break;
          }
          case 48: {
            HeadImgId = input.ReadInt32();
            break;
          }
          case 56: {
            GoodFeel = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
