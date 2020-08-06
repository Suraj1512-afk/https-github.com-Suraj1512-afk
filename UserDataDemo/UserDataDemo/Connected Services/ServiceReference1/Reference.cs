﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserDataDemo.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/ConsumingWcfServiceAgeCalculatorExample")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentDetails", ReplyAction="http://tempuri.org/IService1/GetStudentDetailsResponse")]
        UserDataDemo.ServiceReference1.Student[] GetStudentDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentDetails", ReplyAction="http://tempuri.org/IService1/GetStudentDetailsResponse")]
        System.Threading.Tasks.Task<UserDataDemo.ServiceReference1.Student[]> GetStudentDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Calculatedays", ReplyAction="http://tempuri.org/IService1/CalculatedaysResponse")]
        int Calculatedays(int day, int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Calculatedays", ReplyAction="http://tempuri.org/IService1/CalculatedaysResponse")]
        System.Threading.Tasks.Task<int> CalculatedaysAsync(int day, int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersData", ReplyAction="http://tempuri.org/IService1/GetUsersDataResponse")]
        ModelsAndDTO.UserDTO GetUsersData(ModelsAndDTO.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersData", ReplyAction="http://tempuri.org/IService1/GetUsersDataResponse")]
        System.Threading.Tasks.Task<ModelsAndDTO.UserDTO> GetUsersDataAsync(ModelsAndDTO.UserDTO userDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : UserDataDemo.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<UserDataDemo.ServiceReference1.IService1>, UserDataDemo.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UserDataDemo.ServiceReference1.Student[] GetStudentDetails() {
            return base.Channel.GetStudentDetails();
        }
        
        public System.Threading.Tasks.Task<UserDataDemo.ServiceReference1.Student[]> GetStudentDetailsAsync() {
            return base.Channel.GetStudentDetailsAsync();
        }
        
        public int Calculatedays(int day, int month, int year) {
            return base.Channel.Calculatedays(day, month, year);
        }
        
        public System.Threading.Tasks.Task<int> CalculatedaysAsync(int day, int month, int year) {
            return base.Channel.CalculatedaysAsync(day, month, year);
        }
        
        public ModelsAndDTO.UserDTO GetUsersData(ModelsAndDTO.UserDTO userDTO) {
            return base.Channel.GetUsersData(userDTO);
        }
        
        public System.Threading.Tasks.Task<ModelsAndDTO.UserDTO> GetUsersDataAsync(ModelsAndDTO.UserDTO userDTO) {
            return base.Channel.GetUsersDataAsync(userDTO);
        }
    }
}