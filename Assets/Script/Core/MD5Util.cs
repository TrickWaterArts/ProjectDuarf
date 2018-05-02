﻿using System.Text;

public static class MD5Util {

	public static string Hash(string input) {
		using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create()) {
			byte[] inputBytes = Encoding.UTF8.GetBytes(input);
			byte[] hashBytes = md5.ComputeHash(inputBytes);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++) {
				sb.Append(hashBytes[i].ToString("X2"));
			}
			return sb.ToString();
		}
	}

}