#include <iostream>
#include <DHT.h>
#include <WiFi.h>
#include <WifiUdp.h>
#include <string>

using namespace std;

//INPUT GPIO
#define sensor_1 15

#define SAMPLES 10

// WiFi network
const char * ssid = "hello_world";       //WiFi name
const char * pass = "//10ser**0x1998;";  //Password

//IP address broadcast
const char * udpAddress = "192.168.0.9"; //PC IP
const int udpPort = 8080;                //Port

//Create temp_read instance 
DHT dht(sensor_1, DHT11);
//Create UDP instance
WiFiUDP udp;

class System {
  public:
    int i;
    float t,h,f;
    float hic;
    bool state;
    char bufferData[SAMPLES] = "---" ;

    /*Constructor*/
    System(){
      state = false;
    }
    
    void Run(bool state){
      /* Reading values */
      t = dht.readTemperature();
      h = dht.readHumidity();
      f = dht.readTemperature(true);
  
      hic = dht.computeHeatIndex(t, h, false);

      cout << "temp -> " << hic << endl;

      // SEND
      udp.beginPacket(udpAddress, udpPort);
      udp.print(hic);
      udp.endPacket();
      memset(bufferData, 0, SAMPLES);
      //----------------------------RECEIVE
      //processing incoming packet, must be called before reading the buffer
      udp.parsePacket();
      
      //receive response from server, it will be HELLO WORLD
      if(udp.read(bufferData, 50) > 0){
        Serial.print("Server to client: ");
        Serial.println((char *)bufferData);
      }
      
    }
    ~System(){}
};

void setup() {
  Serial.begin(115200);
  //Connect to the temperature sensor
  dht.begin();
  //Connect to the WiFi network
  WiFi.begin(ssid, pass);

  // Wait for connection
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  cout << "Connected to " << ssid 
       << "IP address: "  << WiFi.localIP() 
       << endl;

  //udp and transfer buffer
  udp.begin(udpPort);
}

void loop() {
  /* Objet created successful*/
  System test;
   /*Execute system*/
  test.Run(true);
  delay (4000);
}
