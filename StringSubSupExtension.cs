/*
 * Copyright © 2021 shamork <shamork@163.com>
 * Thanks to https://github.com/lynn9388/supsub
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shamork.Util
{
	public static class StringSubSupExtension
	{
		#region dic

		public static readonly IReadOnlyDictionary<char, char> SuperscriptsDictionary = new Dictionary<int, int>()
		{
			// Superscripts - Superscripts and Subscripts
			// https://www.unicode.org/charts/PDF/U2070.pdf
			{0x0030, 0x2070},
			{0x0069, 0x2071},
			{0x0034, 0x2074},
			{0x0035, 0x2075},
			{0x0036, 0x2076},
			{0x0037, 0x2077},
			{0x0038, 0x2078},
			{0x0039, 0x2079},
			{0x002b, 0x207a},
			{0x2212, 0x207b},
			{0x002d, 0x207b},
			{0x003d, 0x207c},
			{0x0028, 0x207d},
			{0x0029, 0x207e},
			{0x006e, 0x207f},

			// Latin superscript modifier letters - Spacing Modifier Letters
			// https://www.unicode.org/charts/PDF/U02B0.pdf
			{0x0068, 0x02b0},
			{0x0266, 0x02b1},
			{0x006a, 0x02b2},
			{0x0072, 0x02b3},
			{0x0279, 0x02b4},
			{0x027b, 0x02b5},
			{0x0281, 0x02b6},
			{0x0077, 0x02b7},
			{0x0079, 0x02b8},

			// Additions based on 1989 IPA - Spacing Modifier Letters
			// https://www.unicode.org/charts/PDF/U02B0.pdf
			{0x0263, 0x02e0},
			{0x006c, 0x02e1},
			{0x0073, 0x02e2},
			{0x0078, 0x02e3},
			{0x0295, 0x02e4},

			// Latin superscript modifier letters - Phonetic Extensions
			// https://www.unicode.org/charts/PDF/U1D00.pdf
			{0x0041, 0x1d2c},
			{0x00c6, 0x1d2d},
			{0x0042, 0x1d2e},
			{0x0044, 0x1d30},
			{0x0045, 0x1d31},
			{0x018e, 0x1d32},
			{0x0047, 0x1d33},
			{0x0048, 0x1d34},
			{0x0049, 0x1d35},
			{0x004a, 0x1d36},
			{0x004b, 0x1d37},
			{0x004c, 0x1d38},
			{0x004d, 0x1d39},
			{0x004e, 0x1d3a},
			{0x004f, 0x1d3c},
			{0x0222, 0x1d3d},
			{0x0050, 0x1d3e},
			{0x0052, 0x1d3f},
			{0x0054, 0x1d40},
			{0x0055, 0x1d41},
			{0x0057, 0x1d42},
			{0x0061, 0x1d43}, // '\u0061'(a) '\u1d43'(ᵃ) '\u00aa'(ª)
			{0x0250, 0x1d44},
			{0x0251, 0x1d45},
			{0x1d02, 0x1d46},
			{0x0062, 0x1d47},
			{0x0064, 0x1d48},
			{0x0065, 0x1d49},
			{0x0259, 0x1d4a},
			{0x025b, 0x1d4b},
			{0x1d08, 0x1d4c},
			{0x0067, 0x1d4d},
			{0x006b, 0x1d4f},
			{0x006d, 0x1d50},
			{0x014b, 0x1d51},
			{0x006f, 0x1d52}, // '\u006f'(o) '\u1d52'(ᵒ) '\u00ba'(º)
			{0x0254, 0x1d53},
			{0x1d16, 0x1d54},
			{0x1d17, 0x1d55},
			{0x0070, 0x1d56},
			{0x0074, 0x1d57},
			{0x0075, 0x1d58},
			{0x1d1d, 0x1d59},
			{0x026f, 0x1d5a},
			{0x0076, 0x1d5b},
			{0x1d25, 0x1d5c},

			// Greek superscript modifier letters - Phonetic Extensions
			// https://www.unicode.org/charts/PDF/U1D00.pdf
			{0x03b2, 0x1d5d},
			{0x03b3, 0x1d5e},
			{0x03b4, 0x1d5f},
			{0x03c6, 0x1d60},
			{0x03c7, 0x1d61},

			// Caucasian linguistics - Phonetic Extensions
			// https://www.unicode.org/charts/PDF/U1D00.pdf
			{0x043d, 0x1d78},

			// Modifier letters - Phonetic Extensions Supplement
			// https://www.unicode.org/charts/PDF/U1D80.pdf
			{0x0252, 0x1d9b},
			{0x0063, 0x1d9c},
			{0x0255, 0x1d9d},
			{0x00f0, 0x1d9e},
			{0x025c, 0x1d9f},
			{0x0066, 0x1da0},
			{0x025f, 0x1da1},
			{0x0261, 0x1da2},
			{0x0265, 0x1da3},
			{0x0268, 0x1da4},
			{0x0269, 0x1da5},
			{0x026a, 0x1da6},
			{0x1d7b, 0x1da7},
			{0x029d, 0x1da8},
			{0x026d, 0x1da9},
			{0x1d85, 0x1daa},
			{0x029f, 0x1dab},
			{0x0271, 0x1dac},
			{0x0270, 0x1dad},
			{0x0272, 0x1dae},
			{0x0273, 0x1daf},
			{0x0274, 0x1db0},
			{0x0275, 0x1db1},
			{0x0278, 0x1db2},
			{0x0282, 0x1db3},
			{0x0283, 0x1db4},
			{0x01ab, 0x1db5},
			{0x0289, 0x1db6},
			{0x028a, 0x1db7},
			{0x1d1c, 0x1db8},
			{0x028b, 0x1db9},
			{0x028c, 0x1dba},
			{0x007a, 0x1dbb},
			{0x0290, 0x1dbc},
			{0x0291, 0x1dbd},
			{0x0292, 0x1dbe},
			{0x03b8, 0x1dbf},

			// Latin-1 punctuation and symbols - C1 Controls and Latin-1 Supplement
			// https://www.unicode.org/charts/PDF/U0080.pdf
			//'\u0061': '\u00aa', // '\u0061'(a) '\u1d43'(ᵃ) '\u00aa'(ª)
			{0x0032, 0x00b2},
			{0x0033, 0x00b3},
			{0x0031, 0x00b9},
			//'\u006f': '\u00ba', // '\u006f'(o) '\u1d52'(ᵒ) '\u00ba'(º)
		}.ToDictionary(x => char.ConvertFromUtf32(x.Key)[0], x => char.ConvertFromUtf32(x.Value)[0]);

		public static readonly IReadOnlyDictionary<char, char> SubscriptsDictionary = new Dictionary<int, int>()
		{
			// Subscripts - Superscripts and Subscripts
			// https://www.unicode.org/charts/PDF/U2070.pdf
			{0x0030, 0x2080},
			{0x0031, 0x2081},
			{0x0032, 0x2082},
			{0x0033, 0x2083},
			{0x0034, 0x2084},
			{0x0035, 0x2085},
			{0x0036, 0x2086},
			{0x0037, 0x2087},
			{0x0038, 0x2088},
			{0x0039, 0x2089},
			{0x002b, 0x208a},
			{0x2212, 0x208b},
			{0x002d, 0x208b},
			{0x003d, 0x208c},
			{0x0028, 0x208d},
			{0x0029, 0x208e},
			{0x0061, 0x2090},
			{0x0065, 0x2091},
			{0x006f, 0x2092},
			{0x0078, 0x2093},
			{0x0259, 0x2094},

			// Subscripts for UPA - Superscripts and Subscripts
			// https://www.unicode.org/charts/PDF/U2070.pdf
			{0x0068, 0x2095},
			{0x006b, 0x2096},
			{0x006c, 0x2097},
			{0x006d, 0x2098},
			{0x006e, 0x2099},
			{0x0070, 0x209a},
			{0x0073, 0x209b},
			{0x0074, 0x209c},

			// Latin subscript modifier letters - Phonetic Extensions
			// https://www.unicode.org/charts/PDF/U1D00.pdf
			{0x0069, 0x1d62},
			{0x0072, 0x1d63},
			{0x0075, 0x1d64},
			{0x0076, 0x1d65},

			// Greek subscript modifier letters - Phonetic Extensions
			// https://www.unicode.org/charts/PDF/U1D00.pdf
			{0x03b2, 0x1d66},
			{0x03b3, 0x1d67},
			{0x03c1, 0x1d68},
			{0x03c6, 0x1d69},
			{0x03c7, 0x1d6a}
		}.ToDictionary(x => char.ConvertFromUtf32(x.Key)[0], x => char.ConvertFromUtf32(x.Value)[0]);

		#endregion

		private static string GetInternal(string input, IReadOnlyDictionary<char, char> table)
		{
			if (string.IsNullOrEmpty(input))
				return input;
			var buf = new char[input.Length];
			var span = input.AsSpan();
			for (int i = 0; i < span.Length; i++)
			{
				buf[i] = table.TryGetValue(span[i], out var temp) ? temp : span[i];
			}

			return new string(buf);
		}

		/// <summary>
		/// convert <paramref name="input"/> to subscripts as it can. for chars does not have a subscript, return the input char.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string ToSubscripts(string input) => GetInternal(input, SubscriptsDictionary);

		/// <summary>
		/// convert <paramref name="input"/> to superscripts as it can. for chars does not have a superscript, return the input char.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string ToSuperscripts(string input) => GetInternal(input, SuperscriptsDictionary);
	}
}