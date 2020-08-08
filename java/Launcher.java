// imports
import java.net.InetAddress;
import java.net.URL;

// exceptions
import java.net.UnknownHostException;
import java.net.MalformedURLException;

public class Launcher {
    public static void main(String[] args) {
        
        String domainName = "novurix.com";
        try {
            InetAddress ipAddr = InetAddress.getByName(new URL("https://"+domainName).getHost());
            System.out.println("[" + ipAddr + "] is the IP for " + domainName);
        }catch(MalformedURLException | UnknownHostException e) {}
    }
}
