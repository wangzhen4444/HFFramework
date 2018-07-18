// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: building.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Centersdk.Protobuf {

  /// <summary>Holder for reflection information generated from building.proto</summary>
  public static partial class BuildingReflection {

    #region Descriptor
    /// <summary>File descriptor for building.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5idWlsZGluZy5wcm90bxISY2VudGVyc2RrLnByb3RvYnVmIk8KDEJ1aWxk",
            "aW5nTGlzdBIOCgZVc2VySWQYASABKAUSLwoJQnVpbGRpbmdzGAIgAygLMhwu",
            "Y2VudGVyc2RrLnByb3RvYnVmLkJ1aWxkaW5nIsoBCghCdWlsZGluZxISCgpC",
            "dWlsZGluZ0lkGAEgASgFEhUKDUJ1aWxkaW5nTGV2ZWwYAiABKAUSEgoKRWZm",
            "ZWN0VHlwZRgDIAEoBRIRCglFZmZyY3RWYWwYBCABKAESFAoMQ2FyZEluRWZm",
            "ZWN0GAUgASgBEhMKC0xldmVsVXBUeXBlGAYgASgFEhIKCkxldmVsVXBWYWwY",
            "ByABKAESEwoLTGV2ZWxDb3N0SWQYCCABKAUSGAoQTGV2ZWxVcENvc3RDb3Vu",
            "dBgJIAEoBUIuCh1jb20uaG9vbGFpLmNlbnRlcnNkay5wcm90b2J1ZkINQnVp",
            "bGRpbmdQcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Centersdk.Protobuf.BuildingList), global::Centersdk.Protobuf.BuildingList.Parser, new[]{ "UserId", "Buildings" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Centersdk.Protobuf.Building), global::Centersdk.Protobuf.Building.Parser, new[]{ "BuildingId", "BuildingLevel", "EffectType", "EffrctVal", "CardInEffect", "LevelUpType", "LevelUpVal", "LevelCostId", "LevelUpCostCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///建筑列表
  /// </summary>
  public sealed partial class BuildingList : pb::IMessage<BuildingList> {
    private static readonly pb::MessageParser<BuildingList> _parser = new pb::MessageParser<BuildingList>(() => new BuildingList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildingList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Centersdk.Protobuf.BuildingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildingList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildingList(BuildingList other) : this() {
      userId_ = other.userId_;
      buildings_ = other.buildings_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildingList Clone() {
      return new BuildingList(this);
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    /// <summary>
    ///用户id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "Buildings" field.</summary>
    public const int BuildingsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Centersdk.Protobuf.Building> _repeated_buildings_codec
        = pb::FieldCodec.ForMessage(18, global::Centersdk.Protobuf.Building.Parser);
    private readonly pbc::RepeatedField<global::Centersdk.Protobuf.Building> buildings_ = new pbc::RepeatedField<global::Centersdk.Protobuf.Building>();
    /// <summary>
    ///建筑列表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Centersdk.Protobuf.Building> Buildings {
      get { return buildings_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildingList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildingList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if(!buildings_.Equals(other.buildings_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      hash ^= buildings_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      buildings_.WriteTo(output, _repeated_buildings_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      size += buildings_.CalculateSize(_repeated_buildings_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildingList other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      buildings_.Add(other.buildings_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
          case 18: {
            buildings_.AddEntriesFrom(input, _repeated_buildings_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///单个建筑
  /// </summary>
  public sealed partial class Building : pb::IMessage<Building> {
    private static readonly pb::MessageParser<Building> _parser = new pb::MessageParser<Building>(() => new Building());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Building> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Centersdk.Protobuf.BuildingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Building() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Building(Building other) : this() {
      buildingId_ = other.buildingId_;
      buildingLevel_ = other.buildingLevel_;
      effectType_ = other.effectType_;
      effrctVal_ = other.effrctVal_;
      cardInEffect_ = other.cardInEffect_;
      levelUpType_ = other.levelUpType_;
      levelUpVal_ = other.levelUpVal_;
      levelCostId_ = other.levelCostId_;
      levelUpCostCount_ = other.levelUpCostCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Building Clone() {
      return new Building(this);
    }

    /// <summary>Field number for the "BuildingId" field.</summary>
    public const int BuildingIdFieldNumber = 1;
    private int buildingId_;
    /// <summary>
    ///建筑id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BuildingId {
      get { return buildingId_; }
      set {
        buildingId_ = value;
      }
    }

    /// <summary>Field number for the "BuildingLevel" field.</summary>
    public const int BuildingLevelFieldNumber = 2;
    private int buildingLevel_;
    /// <summary>
    ///建筑等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BuildingLevel {
      get { return buildingLevel_; }
      set {
        buildingLevel_ = value;
      }
    }

    /// <summary>Field number for the "EffectType" field.</summary>
    public const int EffectTypeFieldNumber = 3;
    private int effectType_;
    /// <summary>
    ///建筑效果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EffectType {
      get { return effectType_; }
      set {
        effectType_ = value;
      }
    }

    /// <summary>Field number for the "EffrctVal" field.</summary>
    public const int EffrctValFieldNumber = 4;
    private double effrctVal_;
    /// <summary>
    ///效果数值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double EffrctVal {
      get { return effrctVal_; }
      set {
        effrctVal_ = value;
      }
    }

    /// <summary>Field number for the "CardInEffect" field.</summary>
    public const int CardInEffectFieldNumber = 5;
    private double cardInEffect_;
    /// <summary>
    ///卡牌入驻后效果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CardInEffect {
      get { return cardInEffect_; }
      set {
        cardInEffect_ = value;
      }
    }

    /// <summary>Field number for the "LevelUpType" field.</summary>
    public const int LevelUpTypeFieldNumber = 6;
    private int levelUpType_;
    /// <summary>
    ///升级类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LevelUpType {
      get { return levelUpType_; }
      set {
        levelUpType_ = value;
      }
    }

    /// <summary>Field number for the "LevelUpVal" field.</summary>
    public const int LevelUpValFieldNumber = 7;
    private double levelUpVal_;
    /// <summary>
    ///升级数值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LevelUpVal {
      get { return levelUpVal_; }
      set {
        levelUpVal_ = value;
      }
    }

    /// <summary>Field number for the "LevelCostId" field.</summary>
    public const int LevelCostIdFieldNumber = 8;
    private int levelCostId_;
    /// <summary>
    ///升级消耗类型 1为游戏币
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LevelCostId {
      get { return levelCostId_; }
      set {
        levelCostId_ = value;
      }
    }

    /// <summary>Field number for the "LevelUpCostCount" field.</summary>
    public const int LevelUpCostCountFieldNumber = 9;
    private int levelUpCostCount_;
    /// <summary>
    ///消耗数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LevelUpCostCount {
      get { return levelUpCostCount_; }
      set {
        levelUpCostCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Building);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Building other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuildingId != other.BuildingId) return false;
      if (BuildingLevel != other.BuildingLevel) return false;
      if (EffectType != other.EffectType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EffrctVal, other.EffrctVal)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CardInEffect, other.CardInEffect)) return false;
      if (LevelUpType != other.LevelUpType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LevelUpVal, other.LevelUpVal)) return false;
      if (LevelCostId != other.LevelCostId) return false;
      if (LevelUpCostCount != other.LevelUpCostCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BuildingId != 0) hash ^= BuildingId.GetHashCode();
      if (BuildingLevel != 0) hash ^= BuildingLevel.GetHashCode();
      if (EffectType != 0) hash ^= EffectType.GetHashCode();
      if (EffrctVal != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EffrctVal);
      if (CardInEffect != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CardInEffect);
      if (LevelUpType != 0) hash ^= LevelUpType.GetHashCode();
      if (LevelUpVal != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LevelUpVal);
      if (LevelCostId != 0) hash ^= LevelCostId.GetHashCode();
      if (LevelUpCostCount != 0) hash ^= LevelUpCostCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BuildingId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BuildingId);
      }
      if (BuildingLevel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BuildingLevel);
      }
      if (EffectType != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(EffectType);
      }
      if (EffrctVal != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(EffrctVal);
      }
      if (CardInEffect != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(CardInEffect);
      }
      if (LevelUpType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(LevelUpType);
      }
      if (LevelUpVal != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(LevelUpVal);
      }
      if (LevelCostId != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(LevelCostId);
      }
      if (LevelUpCostCount != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(LevelUpCostCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BuildingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BuildingId);
      }
      if (BuildingLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BuildingLevel);
      }
      if (EffectType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EffectType);
      }
      if (EffrctVal != 0D) {
        size += 1 + 8;
      }
      if (CardInEffect != 0D) {
        size += 1 + 8;
      }
      if (LevelUpType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LevelUpType);
      }
      if (LevelUpVal != 0D) {
        size += 1 + 8;
      }
      if (LevelCostId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LevelCostId);
      }
      if (LevelUpCostCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LevelUpCostCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Building other) {
      if (other == null) {
        return;
      }
      if (other.BuildingId != 0) {
        BuildingId = other.BuildingId;
      }
      if (other.BuildingLevel != 0) {
        BuildingLevel = other.BuildingLevel;
      }
      if (other.EffectType != 0) {
        EffectType = other.EffectType;
      }
      if (other.EffrctVal != 0D) {
        EffrctVal = other.EffrctVal;
      }
      if (other.CardInEffect != 0D) {
        CardInEffect = other.CardInEffect;
      }
      if (other.LevelUpType != 0) {
        LevelUpType = other.LevelUpType;
      }
      if (other.LevelUpVal != 0D) {
        LevelUpVal = other.LevelUpVal;
      }
      if (other.LevelCostId != 0) {
        LevelCostId = other.LevelCostId;
      }
      if (other.LevelUpCostCount != 0) {
        LevelUpCostCount = other.LevelUpCostCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            BuildingId = input.ReadInt32();
            break;
          }
          case 16: {
            BuildingLevel = input.ReadInt32();
            break;
          }
          case 24: {
            EffectType = input.ReadInt32();
            break;
          }
          case 33: {
            EffrctVal = input.ReadDouble();
            break;
          }
          case 41: {
            CardInEffect = input.ReadDouble();
            break;
          }
          case 48: {
            LevelUpType = input.ReadInt32();
            break;
          }
          case 57: {
            LevelUpVal = input.ReadDouble();
            break;
          }
          case 64: {
            LevelCostId = input.ReadInt32();
            break;
          }
          case 72: {
            LevelUpCostCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code