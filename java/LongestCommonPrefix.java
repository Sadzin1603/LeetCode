class LongestCommonPrefix {
    public String longestCommonPrefix(String[] strs) {
        if (strs.length == 0 || strs[0].equals("")) {
            return "";
        }

        String str = "";
        int len = strs.length;
        int tamanho = 1;

        while (tamanho <= strs[0].length()) {
            String teste = strs[0].substring(0, tamanho);

            for (int i = 1; i < len; i++) {
                if (tamanho > strs[i].length()) {
                    return str;
                }

                if (!strs[i].startsWith(teste)) {
                    return str;
                }
            }

            str = teste;
            tamanho++;
        }

        return str;
    }
}