import { StyleSheet, Text, View, Image, TouchableOpacity, TextInput } from 'react-native';
import React from 'react';

import * as Animatable from 'react-native-animatable';

export default function SignIn() {

  const [text, setText] = React.useState('');
  
  return(
    <View style={styles.container}>
      <Image style={styles.imgMain}
        
      />
      <View style={styles.span}>
        <Text style={styles.email}>Email</Text>
        <TextInput style={styles.txtEmail}
            placeholder='ricardinho@gmail.com'
            keyboardType='text'
        />
        <Text style={styles.password}>Senha</Text>
        <TextInput style={styles.txtPassword}
            placeholder='************'
            keyboardType='text'
        />
        
          <Text style={styles.recoverPassword}>Esqueceu senha? <Text style={styles.spanRecoverPassword}>Clique aqui</Text></Text>
        
        <TouchableOpacity style={styles.btnMain}>
            <Text style={styles.signIn}>Login</Text>
      </TouchableOpacity>
      <Text style={styles.or}>Ou</Text>
      <View style={styles.images}>
        <Image style={styles.imgFacebook}
            source={require("./assets/facebook.png")}
        />
        <Image style={styles.imgGoogle}
            source={require("./assets/google.png")}
        />
        <Image style={styles.imgApple}
            source={require("./assets/apple.png")}
        />
      </View>

      {/* <Link href={"/signUp"}>
        <Text style={styles.signUp}>Não possui cadastro? <Text style={styles.spanSignUp}>Cadastre-se</Text></Text>
      </Link> */}
      </View>
    </View>
  )
}

const styles = StyleSheet.create({
  container:{
    flex: 1,
    backgroundColor: "#F5AFAF",
    justifyContent: 'center',
    alignItems: 'center'
  },
  imgMain:{
    width: 250,
    height: 253
  },
  span:{
    width: "100%",
    height: "68.75%",
    backgroundColor: "#FFFFFF",
    justifyContent: 'center',
    alignItems: 'center',
    borderTopRightRadius: 50,
    borderTopLeftRadius: 50,
    marginTop: 25
  },
  email:{
    width: "72.5%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'left',
  },
  txtEmail:{
    width: "75%",
    height: 43.75,
    color: "#000000",
    backgroundColor: "#EDEDED",
    borderRadius: 12.5,
    textAlign: 'justify',
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  password:{
    width: "72.5%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'left',
  },
  txtPassword:{
    width: "75%",
    height: 43.75,
    color: "#000000",
    backgroundColor: "#EDEDED",
    borderRadius: 12.5,
    textAlign: 'justify',
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  recoverPassword:{
    width: "75%",
    color: "#000000",
    fontSize: 15.625,
    textAlign: 'left',
  },
  spanRecoverPassword:{
    color: "#7D0A0A",
    fontSize: 18,
    fontWeight: 'bold'
  },
  btnMain:{
    width: "75%",
    height: 50,
    backgroundColor: "#CA6060",
    borderRadius: 18.75,
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: 25,
    marginBottom: 25
  },
  signIn:{
    color: "#FFFFFF",
    fontSize: 25,
  },
  or:{
    width: "75%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'center'
  },
  images:{
    width: "75%",
    height: "18.75%",
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'row',
    gap: 18.75
  },
  imgFacebook:{
    width: 50,
    height: 50
  },
  imgGoogle:{
    width: 50,
    height: 50
  },
  imgApple:{
    width: 50,
    height: 50
  },
  signUp:{
    color: "#000000",
    fontSize: 15.625,
  },
  spanSignUp:{
    color: "#3E8914",
    fontSize: 15.625,
  }
})