import { View, Text, StyleSheet, Image, TextInput, TouchableOpacity } from 'react-native';

export default function Email(){
  return(
    <View style={styles.container}>
      <Image style={styles.imgMain}
        source={require('../onna-user-app/assets/email.png')}
      />
        <Text style={styles.email}>Atenção</Text>
        <Text style={styles.password}>Enviamos um código para seu email, verifique sua caixa de entrada</Text>
        <Text style={styles.timer}>01:00</Text>
        <TouchableOpacity style={styles.btnMain}>
            <Text style={styles.signIn}>Reenviar</Text>
        </TouchableOpacity>
      
        <Text style={styles.signUp}>Já recebeu? <Text style={styles.spanSignUp}>Login</Text></Text>
      
    </View>
  )
}

const styles = StyleSheet.create({
  container:{
    flex: 1,
    backgroundColor: "#0000",
    justifyContent: 'center',
    alignItems: 'center'
  },
  imgMain:{
    width: 300,
    height: 303
  },
  email:{
    color: "#7D0A0A",
    fontSize: 62.5,
    fontWeight: 'bold'
  },
  password:{
    width: "75%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'center',
  },
  timer:{
    width: "75%",
    color: "#000000",
    fontSize: 25,
    textAlign: 'center',
    fontFamily: "YanoneKaffeesatz_700Bold"
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
    fontFamily: "YanoneKaffeesatz_400Regular"
  },
  signUp:{
    color: "#000000",
    fontSize: 15.625,
    fontFamily: "OpenSans_400Regular",
  },
  spanSignUp:{
    color: "#7D0A0A",
    fontSize: 18,
    fontWeight: 'bold'
  }
})