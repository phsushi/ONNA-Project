import { View, Text, StyleSheet, Image, TouchableOpacity } from 'react-native'
import { useFonts, YanoneKaffeesatz_400Regular } from '@expo-google-fonts/yanone-kaffeesatz'
import { OpenSans_400Regular } from '@expo-google-fonts/open-sans'

export default function App(){
  const [fonts] = useFonts({
    YanoneKaffeesatz_400Regular,
    OpenSans_400Regular
  })

  if (!fonts) {
    return null
  }

  return(
    <View style={styles.container}>
      <Text style={styles.title}>Vamos começar!</Text>
      <Image style={styles.imgMain}
        source={require("./src/assets/img/doctors.png")}
      />
      <TouchableOpacity style={styles.btnSignUp}>
        <Text style={styles.signUp}>Inscrever-se</Text>
      </TouchableOpacity>
      <Text style={styles.signIn}>Já tem uma conta?<Text style={styles.signInSpan}> Entrar</Text></Text>
    </View>
  )
}

const styles = StyleSheet.create({
  container:{
    flex: 1,
    backgroundColor: "#344E41",
    justifyContent: 'center',
    alignItems: 'center'
  },
  title:{
    color: "#DAD7CD",
    fontSize: 50,
    fontFamily: "YanoneKaffeesatz_400Regular",
    marginBottom: 50
  },
  imgMain:{
    width: 375,
    height: 398,
    /*
    borderStyle: 'solid',
    borderColor: "#000000",
    borderWidth: 1,
    */
    marginTop: 50,
    marginBottom: 25
  },
  btnSignUp:{
    width: "75%",
    height: 50,
    backgroundColor: "#A3B18A",
    justifyContent: 'center',
    alignItems: 'center',
    borderRadius: 12.5,
    marginTop: 25,
    marginBottom: 12.5
  },
  signUp:{
    color: "#000000",
    fontSize: 25,
    fontFamily: "YanoneKaffeesatz_400Regular"
  },
  signIn:{
    color: "#DAD7CD",
    fontSize: 18.75,
    fontFamily: "OpenSans_400Regular",
    marginTop: 12.5
  }
  ,
  signInSpan:{
    color: "#000000",
    fontSize: 18.75,
    fontFamily: "OpenSans_400Regular"
  }
})