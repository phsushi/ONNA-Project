import {StyleSheet, Text, View, Image, TouchableOpacity, } from 'react-native';


export default function Welcome() {

  return (
    
    <View style={styles.container}>
      <Text style={styles.titulo}>Bem-Vindo(a) ao</Text>
      <Text style={styles.tituloApp}>ONNA</Text>
      <Text style={styles.titulo}>Aplicativo da Mulher</Text>

    <View style={styles.caixinha}>
    <Image
        style={styles.Fotinha}
        source={require('../onna-user-app/assets/mulheresOnna.png')}
      />
    </View>
    
    <TouchableOpacity style = {styles.btnLogin} >
        <Text style={styles.btnLoginText}>Login</Text>
    </TouchableOpacity>


    <Text style={styles.titulo}>Não possui Cadastro? <Text style={styles.txtCad}>Cadastre-se </Text></Text> 
    
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#F5F5F5',
    alignItems: 'center',
    justifyContent: 'center',
  },

  titulo:{
    fontSize: 20
  },

  tituloApp:{
    color:'#7D0A0A',
    fontSize: 50,
    fontWeight: 'bold'
  },

  txtCad:{
    color:'#7D0A0A',
    fontWeight: 'bold'
  },

  caixinha:{
    borderWidth: 2,
    borderRadius: 10,
    height: 230,
    margin: 20,
    borderColor: 'transparent'
  },

  Fotinha:{
    flex:1,
    alignItems: 'center',
    width: 360
  },

  btnLogin:{
    borderStyle: 'solid',
    borderColor: 'transparent',
    borderWidth: 5,
    borderRadius: 10,
    backgroundColor:'#CA6060',
    width:"80%",
    margin: 30,
    padding: 4
  },

  btnLoginText:{
    color: '#FFF9F9',
    textAlign: 'center',
    fontSize: 20,
  },

  
  
});