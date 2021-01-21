// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/chat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ChatService {

  /// <summary>Holder for reflection information generated from Protos/chat.proto</summary>
  public static partial class ChatReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/chat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b3MvY2hhdC5wcm90byIeCgpSb29tTG9va3VwEhAKCHVzZXJuYW1l",
            "GAEgASgJIh4KCUNoYXRSb29tcxIRCglSb29tTmFtZXMYASADKAkiMwoHTWVz",
            "c2FnZRIMCgR1c2VyGAEgASgJEgwKBHRleHQYAiABKAkSDAoEcm9vbRgDIAEo",
            "BTJNCg9DaGF0Um9vbVNlcnZpY2USHgoESm9pbhIILk1lc3NhZ2UaCC5NZXNz",
            "YWdlKAEwARIaCgRTZW5kEgguTWVzc2FnZRoILk1lc3NhZ2VCDqoCC0NoYXRT",
            "ZXJ2aWNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatService.RoomLookup), global::ChatService.RoomLookup.Parser, new[]{ "Username" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatService.ChatRooms), global::ChatService.ChatRooms.Parser, new[]{ "RoomNames" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatService.Message), global::ChatService.Message.Parser, new[]{ "User", "Text", "Room" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoomLookup : pb::IMessage<RoomLookup> {
    private static readonly pb::MessageParser<RoomLookup> _parser = new pb::MessageParser<RoomLookup>(() => new RoomLookup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomLookup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatService.ChatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomLookup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomLookup(RoomLookup other) : this() {
      username_ = other.username_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomLookup Clone() {
      return new RoomLookup(this);
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 1;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomLookup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomLookup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Username != other.Username) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Username.Length != 0) hash ^= Username.GetHashCode();
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
      if (Username.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Username);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomLookup other) {
      if (other == null) {
        return;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
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
            Username = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatRooms : pb::IMessage<ChatRooms> {
    private static readonly pb::MessageParser<ChatRooms> _parser = new pb::MessageParser<ChatRooms>(() => new ChatRooms());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatRooms> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatService.ChatReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatRooms() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatRooms(ChatRooms other) : this() {
      roomNames_ = other.roomNames_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatRooms Clone() {
      return new ChatRooms(this);
    }

    /// <summary>Field number for the "RoomNames" field.</summary>
    public const int RoomNamesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_roomNames_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> roomNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> RoomNames {
      get { return roomNames_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatRooms);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatRooms other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!roomNames_.Equals(other.roomNames_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= roomNames_.GetHashCode();
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
      roomNames_.WriteTo(output, _repeated_roomNames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += roomNames_.CalculateSize(_repeated_roomNames_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatRooms other) {
      if (other == null) {
        return;
      }
      roomNames_.Add(other.roomNames_);
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
            roomNames_.AddEntriesFrom(input, _repeated_roomNames_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Message : pb::IMessage<Message> {
    private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Message> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatService.ChatReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message(Message other) : this() {
      user_ = other.user_;
      text_ = other.text_;
      room_ = other.room_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message Clone() {
      return new Message(this);
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 1;
    private string user_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string User {
      get { return user_; }
      set {
        user_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 2;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 3;
    private int room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Message);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Message other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (User != other.User) return false;
      if (Text != other.Text) return false;
      if (Room != other.Room) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (User.Length != 0) hash ^= User.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (Room != 0) hash ^= Room.GetHashCode();
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
      if (User.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(User);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Text);
      }
      if (Room != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Room);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (User.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(User);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (Room != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Room);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Message other) {
      if (other == null) {
        return;
      }
      if (other.User.Length != 0) {
        User = other.User;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.Room != 0) {
        Room = other.Room;
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
            User = input.ReadString();
            break;
          }
          case 18: {
            Text = input.ReadString();
            break;
          }
          case 24: {
            Room = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
