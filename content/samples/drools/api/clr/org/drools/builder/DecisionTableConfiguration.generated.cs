//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface DecisionTableConfiguration : global::org.drools.builder.ResourceConfiguration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/builder/DecisionTableInputType;)V")]
        void setInputType(global::org.drools.builder.DecisionTableInputType par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/builder/DecisionTableInputType;")]
        global::org.drools.builder.DecisionTableInputType getInputType();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        void setWorksheetName(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getWorksheetName();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class DecisionTableConfiguration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.@__DecisionTableConfiguration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.builder.DecisionTableConfiguration), typeof(global::org.drools.builder.DecisionTableConfiguration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.builder.DecisionTableConfiguration), typeof(global::org.drools.builder.DecisionTableConfiguration_))]
    internal sealed partial class @__DecisionTableConfiguration : global::java.lang.Object, global::org.drools.builder.DecisionTableConfiguration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _setInputType0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInputType1;
        
        internal static global::net.sf.jni4net.jni.MethodId _setWorksheetName2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getWorksheetName3;
        
        private @__DecisionTableConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.@__DecisionTableConfiguration.staticClass = @__class;
            global::org.drools.builder.@__DecisionTableConfiguration._setInputType0 = @__env.GetMethodID(global::org.drools.builder.@__DecisionTableConfiguration.staticClass, "setInputType", "(Lorg/drools/builder/DecisionTableInputType;)V");
            global::org.drools.builder.@__DecisionTableConfiguration._getInputType1 = @__env.GetMethodID(global::org.drools.builder.@__DecisionTableConfiguration.staticClass, "getInputType", "()Lorg/drools/builder/DecisionTableInputType;");
            global::org.drools.builder.@__DecisionTableConfiguration._setWorksheetName2 = @__env.GetMethodID(global::org.drools.builder.@__DecisionTableConfiguration.staticClass, "setWorksheetName", "(Ljava/lang/String;)V");
            global::org.drools.builder.@__DecisionTableConfiguration._getWorksheetName3 = @__env.GetMethodID(global::org.drools.builder.@__DecisionTableConfiguration.staticClass, "getWorksheetName", "()Ljava/lang/String;");
        }
        
        public void setInputType(global::org.drools.builder.DecisionTableInputType par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.builder.@__DecisionTableConfiguration._setInputType0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public global::org.drools.builder.DecisionTableInputType getInputType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.builder.DecisionTableInputType>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__DecisionTableConfiguration._getInputType1));
            }
        }
        
        public void setWorksheetName(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.builder.@__DecisionTableConfiguration._setWorksheetName2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public global::java.lang.String getWorksheetName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__DecisionTableConfiguration._getWorksheetName3));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__DecisionTableConfiguration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setInputType", "setInputType0", "(Lorg/drools/builder/DecisionTableInputType;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getInputType", "getInputType1", "()Lorg/drools/builder/DecisionTableInputType;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setWorksheetName", "setWorksheetName2", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getWorksheetName", "getWorksheetName3", "()Ljava/lang/String;"));
            return methods;
        }
        
        private static void setInputType0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/builder/DecisionTableInputType;)V
            // (Lorg/drools/builder/DecisionTableInputType;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.builder.DecisionTableConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DecisionTableConfiguration>(@__env, @__obj);
            @__real.setInputType(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.builder.DecisionTableInputType>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getInputType1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/builder/DecisionTableInputType;
            // ()Lorg/drools/builder/DecisionTableInputType;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.DecisionTableConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DecisionTableConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getInputType());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void setWorksheetName2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)V
            // (Ljava/lang/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.builder.DecisionTableConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DecisionTableConfiguration>(@__env, @__obj);
            @__real.setWorksheetName(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getWorksheetName3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.DecisionTableConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DecisionTableConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getWorksheetName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.@__DecisionTableConfiguration(@__env);
            }
        }
    }
    #endregion
}
