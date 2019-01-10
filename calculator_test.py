# -*- coding: utf-8 -*-
"""
Created on Thu Jan 10 19:07:14 2019

@author: eoino
"""

import unittest
from calculator import add, divide, multiply, subtract

class CalculatorTest(unittest.TestCase):
    
    def testAdd(self):
        self.assertEqual(4, add(2, 2))
        self.assertEqual(5, add(2, 3))
        self.assertEqual(8.3, add(2.8, 5.5))
        self.assertEqual('ab', add('a', 'b'))
        
    def testDivide(self):
        self.assertEqual(4, divide(4, 1))
        self.assertEqual(3, divide(6, 2))
        self.assertEqual(5.8, divide(14.5, 2.5))
    
    def testMultiply(self):
        self.assertEqual(4, multiply(2, 2))
        self.assertEqual(9, multiply(3, 3))
        
    def testSubtract(self):
        self.assertEqual(0, subtract(2, 2))
        
    
        
    
        
unittest.main()