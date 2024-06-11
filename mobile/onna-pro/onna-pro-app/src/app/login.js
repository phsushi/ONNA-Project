import { View, Text, StyleSheet, Image, TextInput, TouchableOpacity } from 'react-native';
import { useFonts, YanoneKaffeesatz_400Regular } from '@expo-google-fonts/yanone-kaffeesatz';
import { OpenSans_400Regular } from '@expo-google-fonts/open-sans';
import { Link } from 'expo-router';

export default function Login(){
  const [fontsLoaded] = useFonts({
    YanoneKaffeesatz_400Regular,
    OpenSans_400Regular
  })

  if (!fontsLoaded) {
    return null
  }

  return(
    <View style={styles.container}>
      <Image style={styles.imgMain}
        source={require("../assets//img/doctors-gif.gif")}
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
        <Link href={"/recoveryPassword"}>
          <Text style={styles.recoverPassword}>Esqueceu senha? <Text style={styles.spanRecoverPassword}>Clique aqui</Text></Text>
        </Link>
        <TouchableOpacity style={styles.btnMain}>
            <Text style={styles.signIn}>Login</Text>
      </TouchableOpacity>
      <Text style={styles.or}>Ou</Text>
      <View style={styles.images}>
        <Image style={styles.imgFacebook}
            source={require("../assets/img/facebook.png")}
        />
        <Image style={styles.imgGoogle}
            source={require("../assets//img/google.png")}
        />
        <Image style={styles.imgApple}
            source={require("../assets//img/apple.png")}
        />
      </View>
      <Link href={"/signUp"}>
        <Text style={styles.signUp}>Não possui cadastro? <Text style={styles.spanSignUp}>Cadastre-se</Text></Text>
      </Link>
      </View>
    </View>
  )
}

const styles = StyleSheet.create({
  container:{
    flex: 1,
    backgroundColor: "#E8FCCF",
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
    fontFamily: "OpenSans_400Regular"
  },
  txtEmail:{
    width: "75%",
    height: 43.75,
    color: "#000000",
    backgroundColor: "#EDEDED",
    borderRadius: 12.5,
    textAlign: 'justify',
    fontFamily: "YanoneKaffeesatz_400Regular",
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  password:{
    width: "72.5%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'left',
    fontFamily: "OpenSans_400Regular"
  },
  txtPassword:{
    width: "75%",
    height: 43.75,
    color: "#000000",
    backgroundColor: "#EDEDED",
    borderRadius: 12.5,
    textAlign: 'justify',
    fontFamily: "YanoneKaffeesatz_400Regular",
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  recoverPassword:{
    width: "75%",
    color: "#000000",
    fontSize: 15.625,
    textAlign: 'left',
    fontFamily: "OpenSans_400Regular"
  },
  spanRecoverPassword:{
    color: "#3E8914",
    fontSize: 15.625,
    fontFamily: "OpenSans_400Regular"
  },
  btnMain:{
    width: "75%",
    height: 50,
    backgroundColor: "#3DA35D",
    borderRadius: 18.75,
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: 25,
    marginBottom: 25
  },
  signIn:{
    color: "#FFFFFF",
    fontSize: 25,
    fontFamily: "YanoneKaffeesatz_400Regular"
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
    fontFamily: "OpenSans_400Regular",
  },
  spanSignUp:{
    color: "#3E8914",
    fontSize: 15.625,
    fontFamily: "OpenSans_400Regular"
  }
})