﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirestoneWebTemplate.EmailService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SqlEmail", Namespace="http://schemas.datacontract.org/2004/07/EmailService")]
    [System.SerializableAttribute()]
    public partial class SqlEmail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AttachmentFileLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BccField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IsAttachmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IsHtmlBodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QueryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QueryFileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SqlServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToField;
        
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
        public string AttachmentFileLocation {
            get {
                return this.AttachmentFileLocationField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentFileLocationField, value) != true)) {
                    this.AttachmentFileLocationField = value;
                    this.RaisePropertyChanged("AttachmentFileLocation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bcc {
            get {
                return this.BccField;
            }
            set {
                if ((object.ReferenceEquals(this.BccField, value) != true)) {
                    this.BccField = value;
                    this.RaisePropertyChanged("Bcc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
            get {
                return this.BodyField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyField, value) != true)) {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cc {
            get {
                return this.CcField;
            }
            set {
                if ((object.ReferenceEquals(this.CcField, value) != true)) {
                    this.CcField = value;
                    this.RaisePropertyChanged("Cc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IsAttachment {
            get {
                return this.IsAttachmentField;
            }
            set {
                if ((object.ReferenceEquals(this.IsAttachmentField, value) != true)) {
                    this.IsAttachmentField = value;
                    this.RaisePropertyChanged("IsAttachment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IsHtmlBody {
            get {
                return this.IsHtmlBodyField;
            }
            set {
                if ((object.ReferenceEquals(this.IsHtmlBodyField, value) != true)) {
                    this.IsHtmlBodyField = value;
                    this.RaisePropertyChanged("IsHtmlBody");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Priority {
            get {
                return this.PriorityField;
            }
            set {
                if ((object.ReferenceEquals(this.PriorityField, value) != true)) {
                    this.PriorityField = value;
                    this.RaisePropertyChanged("Priority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Query {
            get {
                return this.QueryField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryField, value) != true)) {
                    this.QueryField = value;
                    this.RaisePropertyChanged("Query");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QueryFileName {
            get {
                return this.QueryFileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryFileNameField, value) != true)) {
                    this.QueryFileNameField = value;
                    this.RaisePropertyChanged("QueryFileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SqlServer {
            get {
                return this.SqlServerField;
            }
            set {
                if ((object.ReferenceEquals(this.SqlServerField, value) != true)) {
                    this.SqlServerField = value;
                    this.RaisePropertyChanged("SqlServer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string To {
            get {
                return this.ToField;
            }
            set {
                if ((object.ReferenceEquals(this.ToField, value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmailService.IEmailRestService")]
    public interface IEmailRestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailRestService/SendSQLEmail", ReplyAction="http://tempuri.org/IEmailRestService/SendSQLEmailResponse")]
        bool SendSQLEmail(FirestoneWebTemplate.EmailService.SqlEmail email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailRestService/SendSQLEmail", ReplyAction="http://tempuri.org/IEmailRestService/SendSQLEmailResponse")]
        System.Threading.Tasks.Task<bool> SendSQLEmailAsync(FirestoneWebTemplate.EmailService.SqlEmail email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailRestServiceChannel : FirestoneWebTemplate.EmailService.IEmailRestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailRestServiceClient : System.ServiceModel.ClientBase<FirestoneWebTemplate.EmailService.IEmailRestService>, FirestoneWebTemplate.EmailService.IEmailRestService {
        
        public EmailRestServiceClient() {
        }
        
        public EmailRestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailRestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailRestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailRestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SendSQLEmail(FirestoneWebTemplate.EmailService.SqlEmail email) {
            return base.Channel.SendSQLEmail(email);
        }
        
        public System.Threading.Tasks.Task<bool> SendSQLEmailAsync(FirestoneWebTemplate.EmailService.SqlEmail email) {
            return base.Channel.SendSQLEmailAsync(email);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmailService.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendEmailAttachment", ReplyAction="http://tempuri.org/IEmailService/SendEmailAttachmentResponse")]
        bool SendEmailAttachment(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string attachment, string[] cc, string[] bcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendEmailAttachment", ReplyAction="http://tempuri.org/IEmailService/SendEmailAttachmentResponse")]
        System.Threading.Tasks.Task<bool> SendEmailAttachmentAsync(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string attachment, string[] cc, string[] bcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendEmail", ReplyAction="http://tempuri.org/IEmailService/SendEmailResponse")]
        bool SendEmail(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string[] cc, string[] bcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendEmail", ReplyAction="http://tempuri.org/IEmailService/SendEmailResponse")]
        System.Threading.Tasks.Task<bool> SendEmailAsync(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string[] cc, string[] bcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendAppointment", ReplyAction="http://tempuri.org/IEmailService/SendAppointmentResponse")]
        bool SendAppointment(string attendeeEmail, string organizerEmail, string organizerName, string subject, string body, bool cancel, System.DateTime startDate, System.DateTime endDate, string location, string uniqueID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendAppointment", ReplyAction="http://tempuri.org/IEmailService/SendAppointmentResponse")]
        System.Threading.Tasks.Task<bool> SendAppointmentAsync(string attendeeEmail, string organizerEmail, string organizerName, string subject, string body, bool cancel, System.DateTime startDate, System.DateTime endDate, string location, string uniqueID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireEvent", ReplyAction="http://tempuri.org/IEmailService/FireEventResponse")]
        bool FireEvent(string data, int eventID, string from, string subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireEvent", ReplyAction="http://tempuri.org/IEmailService/FireEventResponse")]
        System.Threading.Tasks.Task<bool> FireEventAsync(string data, int eventID, string from, string subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireEventOverrideSenders", ReplyAction="http://tempuri.org/IEmailService/FireEventOverrideSendersResponse")]
        bool FireEventOverrideSenders(string data, string[] to, string from, string subject, int eventID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireEventOverrideSenders", ReplyAction="http://tempuri.org/IEmailService/FireEventOverrideSendersResponse")]
        System.Threading.Tasks.Task<bool> FireEventOverrideSendersAsync(string data, string[] to, string from, string subject, int eventID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireApplicationEvent", ReplyAction="http://tempuri.org/IEmailService/FireApplicationEventResponse")]
        bool FireApplicationEvent(string data, string from, string subject, long eventApplicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireApplicationEvent", ReplyAction="http://tempuri.org/IEmailService/FireApplicationEventResponse")]
        System.Threading.Tasks.Task<bool> FireApplicationEventAsync(string data, string from, string subject, long eventApplicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireApplicationEventOverrideSenders", ReplyAction="http://tempuri.org/IEmailService/FireApplicationEventOverrideSendersResponse")]
        bool FireApplicationEventOverrideSenders(string data, string[] to, string from, string subject, long eventApplicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/FireApplicationEventOverrideSenders", ReplyAction="http://tempuri.org/IEmailService/FireApplicationEventOverrideSendersResponse")]
        System.Threading.Tasks.Task<bool> FireApplicationEventOverrideSendersAsync(string data, string[] to, string from, string subject, long eventApplicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/CreateEvent", ReplyAction="http://tempuri.org/IEmailService/CreateEventResponse")]
        long CreateEvent(string name, string xslt, bool IsHTML, long applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/CreateEvent", ReplyAction="http://tempuri.org/IEmailService/CreateEventResponse")]
        System.Threading.Tasks.Task<long> CreateEventAsync(string name, string xslt, bool IsHTML, long applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/RemoveEvent", ReplyAction="http://tempuri.org/IEmailService/RemoveEventResponse")]
        bool RemoveEvent(long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/RemoveEvent", ReplyAction="http://tempuri.org/IEmailService/RemoveEventResponse")]
        System.Threading.Tasks.Task<bool> RemoveEventAsync(long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/CreateSubscription", ReplyAction="http://tempuri.org/IEmailService/CreateSubscriptionResponse")]
        long CreateSubscription(long EventID, string email, long applicationId, long applicationEventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/CreateSubscription", ReplyAction="http://tempuri.org/IEmailService/CreateSubscriptionResponse")]
        System.Threading.Tasks.Task<long> CreateSubscriptionAsync(long EventID, string email, long applicationId, long applicationEventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/CreateApplicationEvent", ReplyAction="http://tempuri.org/IEmailService/CreateApplicationEventResponse")]
        long CreateApplicationEvent(string name, long applictionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/CreateApplicationEvent", ReplyAction="http://tempuri.org/IEmailService/CreateApplicationEventResponse")]
        System.Threading.Tasks.Task<long> CreateApplicationEventAsync(string name, long applictionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/RemoveSubscriptionEventEmail", ReplyAction="http://tempuri.org/IEmailService/RemoveSubscriptionEventEmailResponse")]
        bool RemoveSubscriptionEventEmail(long EventID, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/RemoveSubscriptionEventEmail", ReplyAction="http://tempuri.org/IEmailService/RemoveSubscriptionEventEmailResponse")]
        System.Threading.Tasks.Task<bool> RemoveSubscriptionEventEmailAsync(long EventID, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/RemoveSubscription", ReplyAction="http://tempuri.org/IEmailService/RemoveSubscriptionResponse")]
        bool RemoveSubscription(long SubscriptionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/RemoveSubscription", ReplyAction="http://tempuri.org/IEmailService/RemoveSubscriptionResponse")]
        System.Threading.Tasks.Task<bool> RemoveSubscriptionAsync(long SubscriptionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/GetSubscriptionsByEventId", ReplyAction="http://tempuri.org/IEmailService/GetSubscriptionsByEventIdResponse")]
        string[] GetSubscriptionsByEventId(long EventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/GetSubscriptionsByEventId", ReplyAction="http://tempuri.org/IEmailService/GetSubscriptionsByEventIdResponse")]
        System.Threading.Tasks.Task<string[]> GetSubscriptionsByEventIdAsync(long EventId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : FirestoneWebTemplate.EmailService.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<FirestoneWebTemplate.EmailService.IEmailService>, FirestoneWebTemplate.EmailService.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SendEmailAttachment(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string attachment, string[] cc, string[] bcc) {
            return base.Channel.SendEmailAttachment(to, from, subject, body, isBodyHtml, priority, attachment, cc, bcc);
        }
        
        public System.Threading.Tasks.Task<bool> SendEmailAttachmentAsync(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string attachment, string[] cc, string[] bcc) {
            return base.Channel.SendEmailAttachmentAsync(to, from, subject, body, isBodyHtml, priority, attachment, cc, bcc);
        }
        
        public bool SendEmail(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string[] cc, string[] bcc) {
            return base.Channel.SendEmail(to, from, subject, body, isBodyHtml, priority, cc, bcc);
        }
        
        public System.Threading.Tasks.Task<bool> SendEmailAsync(string[] to, string from, string subject, string body, bool isBodyHtml, string priority, string[] cc, string[] bcc) {
            return base.Channel.SendEmailAsync(to, from, subject, body, isBodyHtml, priority, cc, bcc);
        }
        
        public bool SendAppointment(string attendeeEmail, string organizerEmail, string organizerName, string subject, string body, bool cancel, System.DateTime startDate, System.DateTime endDate, string location, string uniqueID) {
            return base.Channel.SendAppointment(attendeeEmail, organizerEmail, organizerName, subject, body, cancel, startDate, endDate, location, uniqueID);
        }
        
        public System.Threading.Tasks.Task<bool> SendAppointmentAsync(string attendeeEmail, string organizerEmail, string organizerName, string subject, string body, bool cancel, System.DateTime startDate, System.DateTime endDate, string location, string uniqueID) {
            return base.Channel.SendAppointmentAsync(attendeeEmail, organizerEmail, organizerName, subject, body, cancel, startDate, endDate, location, uniqueID);
        }
        
        public bool FireEvent(string data, int eventID, string from, string subject) {
            return base.Channel.FireEvent(data, eventID, from, subject);
        }
        
        public System.Threading.Tasks.Task<bool> FireEventAsync(string data, int eventID, string from, string subject) {
            return base.Channel.FireEventAsync(data, eventID, from, subject);
        }
        
        public bool FireEventOverrideSenders(string data, string[] to, string from, string subject, int eventID) {
            return base.Channel.FireEventOverrideSenders(data, to, from, subject, eventID);
        }
        
        public System.Threading.Tasks.Task<bool> FireEventOverrideSendersAsync(string data, string[] to, string from, string subject, int eventID) {
            return base.Channel.FireEventOverrideSendersAsync(data, to, from, subject, eventID);
        }
        
        public bool FireApplicationEvent(string data, string from, string subject, long eventApplicationId) {
            return base.Channel.FireApplicationEvent(data, from, subject, eventApplicationId);
        }
        
        public System.Threading.Tasks.Task<bool> FireApplicationEventAsync(string data, string from, string subject, long eventApplicationId) {
            return base.Channel.FireApplicationEventAsync(data, from, subject, eventApplicationId);
        }
        
        public bool FireApplicationEventOverrideSenders(string data, string[] to, string from, string subject, long eventApplicationId) {
            return base.Channel.FireApplicationEventOverrideSenders(data, to, from, subject, eventApplicationId);
        }
        
        public System.Threading.Tasks.Task<bool> FireApplicationEventOverrideSendersAsync(string data, string[] to, string from, string subject, long eventApplicationId) {
            return base.Channel.FireApplicationEventOverrideSendersAsync(data, to, from, subject, eventApplicationId);
        }
        
        public long CreateEvent(string name, string xslt, bool IsHTML, long applicationId) {
            return base.Channel.CreateEvent(name, xslt, IsHTML, applicationId);
        }
        
        public System.Threading.Tasks.Task<long> CreateEventAsync(string name, string xslt, bool IsHTML, long applicationId) {
            return base.Channel.CreateEventAsync(name, xslt, IsHTML, applicationId);
        }
        
        public bool RemoveEvent(long Id) {
            return base.Channel.RemoveEvent(Id);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveEventAsync(long Id) {
            return base.Channel.RemoveEventAsync(Id);
        }
        
        public long CreateSubscription(long EventID, string email, long applicationId, long applicationEventId) {
            return base.Channel.CreateSubscription(EventID, email, applicationId, applicationEventId);
        }
        
        public System.Threading.Tasks.Task<long> CreateSubscriptionAsync(long EventID, string email, long applicationId, long applicationEventId) {
            return base.Channel.CreateSubscriptionAsync(EventID, email, applicationId, applicationEventId);
        }
        
        public long CreateApplicationEvent(string name, long applictionId) {
            return base.Channel.CreateApplicationEvent(name, applictionId);
        }
        
        public System.Threading.Tasks.Task<long> CreateApplicationEventAsync(string name, long applictionId) {
            return base.Channel.CreateApplicationEventAsync(name, applictionId);
        }
        
        public bool RemoveSubscriptionEventEmail(long EventID, string email) {
            return base.Channel.RemoveSubscriptionEventEmail(EventID, email);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveSubscriptionEventEmailAsync(long EventID, string email) {
            return base.Channel.RemoveSubscriptionEventEmailAsync(EventID, email);
        }
        
        public bool RemoveSubscription(long SubscriptionID) {
            return base.Channel.RemoveSubscription(SubscriptionID);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveSubscriptionAsync(long SubscriptionID) {
            return base.Channel.RemoveSubscriptionAsync(SubscriptionID);
        }
        
        public string[] GetSubscriptionsByEventId(long EventId) {
            return base.Channel.GetSubscriptionsByEventId(EventId);
        }
        
        public System.Threading.Tasks.Task<string[]> GetSubscriptionsByEventIdAsync(long EventId) {
            return base.Channel.GetSubscriptionsByEventIdAsync(EventId);
        }
    }
}
