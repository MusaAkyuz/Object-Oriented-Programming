
public class musteri {
	private String adi;
	private String adres;
	
	public musteri(String ad, String addr) {
		this.adi = ad;
		this.adres = addr;
	}
	
	public void krediHesap() {
		System.out.println("Kredi Hesaplandı");
	}
	
	public void sparisver(int n) {
		siparis[] s = new siparis[n];
		s[0] = new siparis("Kalem", 10, 5);
		System.out.println(n+" siparis verildi");
		s[0].gonder();
	}
}
