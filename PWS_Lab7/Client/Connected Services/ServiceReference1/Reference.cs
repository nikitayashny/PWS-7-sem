﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Note", Namespace="http://schemas.datacontract.org/2004/07/WSNAPModel")]
    [System.SerializableAttribute()]
    public partial class Note : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference1.Student StudentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> noteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> student_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string subjField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference1.Student Student {
            get {
                return this.StudentField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentField, value) != true)) {
                    this.StudentField = value;
                    this.RaisePropertyChanged("Student");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> note {
            get {
                return this.noteField;
            }
            set {
                if ((this.noteField.Equals(value) != true)) {
                    this.noteField = value;
                    this.RaisePropertyChanged("note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> student_id {
            get {
                return this.student_idField;
            }
            set {
                if ((this.student_idField.Equals(value) != true)) {
                    this.student_idField = value;
                    this.RaisePropertyChanged("student_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string subj {
            get {
                return this.subjField;
            }
            set {
                if ((object.ReferenceEquals(this.subjField, value) != true)) {
                    this.subjField = value;
                    this.RaisePropertyChanged("subj");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WSNAPModel")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference1.Note[] NoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference1.Note[] Note {
            get {
                return this.NoteField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteField, value) != true)) {
                    this.NoteField = value;
                    this.RaisePropertyChanged("Note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFeed")]
    public interface IFeed {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/CreateFeed", ReplyAction="http://tempuri.org/IFeed/CreateFeedResponse")]
        System.ServiceModel.Syndication.SyndicationFeedFormatter CreateFeed();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/CreateFeed", ReplyAction="http://tempuri.org/IFeed/CreateFeedResponse")]
        System.Threading.Tasks.Task<System.ServiceModel.Syndication.SyndicationFeedFormatter> CreateFeedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/GetStudentNotes", ReplyAction="http://tempuri.org/IFeed/GetStudentNotesResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.ServiceModel.Syndication.Atom10FeedFormatter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.ServiceModel.Syndication.Rss20FeedFormatter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.ServiceModel.Syndication.SyndicationFeedFormatter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Client.ServiceReference1.Note[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Client.ServiceReference1.Note))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Client.ServiceReference1.Student))]
        object GetStudentNotes(string studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/GetStudentNotes", ReplyAction="http://tempuri.org/IFeed/GetStudentNotesResponse")]
        System.Threading.Tasks.Task<object> GetStudentNotesAsync(string studentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFeedChannel : Client.ServiceReference1.IFeed, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FeedClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IFeed>, Client.ServiceReference1.IFeed {
        
        public FeedClient() {
        }
        
        public FeedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FeedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.ServiceModel.Syndication.SyndicationFeedFormatter CreateFeed() {
            return base.Channel.CreateFeed();
        }
        
        public System.Threading.Tasks.Task<System.ServiceModel.Syndication.SyndicationFeedFormatter> CreateFeedAsync() {
            return base.Channel.CreateFeedAsync();
        }
        
        public object GetStudentNotes(string studentId) {
            return base.Channel.GetStudentNotes(studentId);
        }
        
        public System.Threading.Tasks.Task<object> GetStudentNotesAsync(string studentId) {
            return base.Channel.GetStudentNotesAsync(studentId);
        }
    }
}
