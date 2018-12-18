// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mail_service_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mailservice.Protobuf {

  /// <summary>Holder for reflection information generated from mail_service_service.proto</summary>
  public static partial class MailServiceServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for mail_service_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MailServiceServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChptYWlsX3NlcnZpY2Vfc2VydmljZS5wcm90bxIUbWFpbHNlcnZpY2UucHJv",
            "dG9idWYiPAoITWFpbExpc3QSMAoIbWFpbmluZm8YASADKAsyHi5tYWlsc2Vy",
            "dmljZS5wcm90b2J1Zi5NYWluSW5mbyJHCghNYWluSW5mbxINCgV0aXRsZRgB",
            "IAEoCRIPCgdjb250ZXh0GAIgASgJEgwKBHRpbWUYAyABKAMSDQoFc3RhdGUY",
            "BCABKAVCMQodY29tLmhvb2xhaS5jb21tb25hcHAucHJvdG9idWZCEE1haWxT",
            "ZXJ2aWNlUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mailservice.Protobuf.MailList), global::Mailservice.Protobuf.MailList.Parser, new[]{ "Maininfo" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mailservice.Protobuf.MainInfo), global::Mailservice.Protobuf.MainInfo.Parser, new[]{ "Title", "Context", "Time", "State" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///邮件列表
  /// </summary>
  public sealed partial class MailList : pb::IMessage<MailList> {
    private static readonly pb::MessageParser<MailList> _parser = new pb::MessageParser<MailList>(() => new MailList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MailList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mailservice.Protobuf.MailServiceServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MailList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MailList(MailList other) : this() {
      maininfo_ = other.maininfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MailList Clone() {
      return new MailList(this);
    }

    /// <summary>Field number for the "maininfo" field.</summary>
    public const int MaininfoFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Mailservice.Protobuf.MainInfo> _repeated_maininfo_codec
        = pb::FieldCodec.ForMessage(10, global::Mailservice.Protobuf.MainInfo.Parser);
    private readonly pbc::RepeatedField<global::Mailservice.Protobuf.MainInfo> maininfo_ = new pbc::RepeatedField<global::Mailservice.Protobuf.MainInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Mailservice.Protobuf.MainInfo> Maininfo {
      get { return maininfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MailList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MailList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!maininfo_.Equals(other.maininfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= maininfo_.GetHashCode();
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
      maininfo_.WriteTo(output, _repeated_maininfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += maininfo_.CalculateSize(_repeated_maininfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MailList other) {
      if (other == null) {
        return;
      }
      maininfo_.Add(other.maininfo_);
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
          case 10: {
            maininfo_.AddEntriesFrom(input, _repeated_maininfo_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///邮件
  /// </summary>
  public sealed partial class MainInfo : pb::IMessage<MainInfo> {
    private static readonly pb::MessageParser<MainInfo> _parser = new pb::MessageParser<MainInfo>(() => new MainInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MainInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mailservice.Protobuf.MailServiceServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MainInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MainInfo(MainInfo other) : this() {
      title_ = other.title_;
      context_ = other.context_;
      time_ = other.time_;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MainInfo Clone() {
      return new MainInfo(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private string title_ = "";
    /// <summary>
    /// 标题
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 2;
    private string context_ = "";
    /// <summary>
    ///内容
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Context {
      get { return context_; }
      set {
        context_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 3;
    private long time_;
    /// <summary>
    /// 时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private int state_;
    /// <summary>
    /// 状态
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MainInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MainInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (Context != other.Context) return false;
      if (Time != other.Time) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Context.Length != 0) hash ^= Context.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
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
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Context.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Context);
      }
      if (Time != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Time);
      }
      if (State != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(State);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Context.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Context);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MainInfo other) {
      if (other == null) {
        return;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Context.Length != 0) {
        Context = other.Context;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.State != 0) {
        State = other.State;
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
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Context = input.ReadString();
            break;
          }
          case 24: {
            Time = input.ReadInt64();
            break;
          }
          case 32: {
            State = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
