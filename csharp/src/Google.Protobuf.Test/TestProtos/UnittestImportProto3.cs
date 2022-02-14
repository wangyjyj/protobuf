// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: unittest_import_proto3.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.TestProtos {

  #region Enums
  public enum ImportEnum {
    Unspecified = 0,
    ImportFoo = 7,
    ImportBar = 8,
    ImportBaz = 9,
  }

  #endregion

  #region Messages
  public sealed class ImportMessage : pb::IMessage, pb::IDeepCloneable {
    private static readonly pb::MessageParser<ImportMessage> _parser = new pb::MessageParser<ImportMessage>(() => new ImportMessage());
    public static pb::MessageParser<ImportMessage> Parser { get { return _parser; } }

    public ImportMessage() {
    }

    public ImportMessage(ImportMessage other) : this() {
      d_ = other.d_;
    }

    public object Clone() {
      return new ImportMessage(this);
    }

    /// <summary>Field number for the "d" field.</summary>
    public const int DFieldNumber = 1;
    private int d_;
    public int D {
      get { return d_; }
      set {
        d_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ImportMessage);
    }

    public bool Equals(ImportMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (D != other.D) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (D != 0) hash ^= D.GetHashCode();
      return hash;
    }

    public override string ToString() {
      var sb = new System.Text.StringBuilder();
      sb.Append("d:").Append(d_).Append(" ");
      return sb.ToString();
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (D != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(D);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (D != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(D);
      }
      return size;
    }

    public void MergeFrom(ImportMessage other) {
      if (other == null) {
        return;
      }
      if (other.D != 0) {
        D = other.D;
      }
    }

    void pb::IMessage.MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            D = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
