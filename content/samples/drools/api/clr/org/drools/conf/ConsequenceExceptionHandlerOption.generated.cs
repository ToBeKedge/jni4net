//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.conf {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ConsequenceExceptionHandlerOption : global::java.lang.Object, global::org.drools.conf.SingleValueKnowledgeBaseOption {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPropertyName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _get1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getHandler2;
        
        internal static global::net.sf.jni4net.jni.FieldId _PROPERTY_NAME3;
        
        protected ConsequenceExceptionHandlerOption(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String PROPERTY_NAME {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass, global::org.drools.conf.ConsequenceExceptionHandlerOption._PROPERTY_NAME3));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass = @__class;
            global::org.drools.conf.ConsequenceExceptionHandlerOption._getPropertyName0 = @__env.GetMethodID(global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass, "getPropertyName", "()Ljava/lang/String;");
            global::org.drools.conf.ConsequenceExceptionHandlerOption._get1 = @__env.GetStaticMethodID(global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass, "get", "(Ljava/lang/Class;)Lorg/drools/conf/ConsequenceExceptionHandlerOption;");
            global::org.drools.conf.ConsequenceExceptionHandlerOption._getHandler2 = @__env.GetMethodID(global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass, "getHandler", "()Ljava/lang/Class;");
            global::org.drools.conf.ConsequenceExceptionHandlerOption._PROPERTY_NAME3 = @__env.GetStaticFieldID(global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass, "PROPERTY_NAME", "Ljava/lang/String;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getPropertyName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.conf.ConsequenceExceptionHandlerOption._getPropertyName0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Lorg/drools/conf/ConsequenceExceptionHandlerOption;")]
        public static global::org.drools.conf.ConsequenceExceptionHandlerOption get(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.conf.ConsequenceExceptionHandlerOption>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.conf.ConsequenceExceptionHandlerOption.staticClass, global::org.drools.conf.ConsequenceExceptionHandlerOption._get1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getHandler() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.conf.ConsequenceExceptionHandlerOption._getHandler2));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.conf.ConsequenceExceptionHandlerOption(@__env);
            }
        }
    }
    #endregion
}
