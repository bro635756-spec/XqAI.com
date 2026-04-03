#include <iostream>
#include <string>
#include <vector>

class XqPacket {
public:
    struct Packet {
        int id;
        std::string data;
        std::string type;
    };

    // Veriyi paketle
    Packet create_packet(int id, std::string content, std::string type) {
        return {id, content, type};
    }

    void send_to_bridge(Packet p) {
        // C# Bridge için çıktı üretir
        std::cout << "[PACKET_SEND][" << p.type << "] ID:" << p.id << " DATA:" << p.data << std::endl;
    }
};

int main() {
    XqPacket xq;
    auto p = xq.create_packet(1, "XqAI System Initialized", "SYSTEM");
    xq.send_to_bridge(p);
    return 0;
}
