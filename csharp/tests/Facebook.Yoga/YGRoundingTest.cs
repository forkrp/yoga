/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

// @Generated by gentest/gentest.rb from gentest/fixtures/YGRoundingTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGRoundingTest
    {
        [Test]
        public void Test_rounding_flex_basis_flex_grow_row_width_of_100()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(33f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(33f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(34f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            Assert.AreEqual(67f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(33f, root_child2.LayoutWidth);
            Assert.AreEqual(100f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(67f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(33f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(33f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(34f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(33f, root_child2.LayoutWidth);
            Assert.AreEqual(100f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_flex_basis_flex_grow_row_prime_number_width()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 113;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root.Insert(2, root_child2);

            YogaNode root_child3 = new YogaNode();
            root_child3.FlexGrow = 1;
            root.Insert(3, root_child3);

            YogaNode root_child4 = new YogaNode();
            root_child4.FlexGrow = 1;
            root.Insert(4, root_child4);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(113f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(23f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(23f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(22f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            Assert.AreEqual(45f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(23f, root_child2.LayoutWidth);
            Assert.AreEqual(100f, root_child2.LayoutHeight);

            Assert.AreEqual(68f, root_child3.LayoutX);
            Assert.AreEqual(0f, root_child3.LayoutY);
            Assert.AreEqual(22f, root_child3.LayoutWidth);
            Assert.AreEqual(100f, root_child3.LayoutHeight);

            Assert.AreEqual(90f, root_child4.LayoutX);
            Assert.AreEqual(0f, root_child4.LayoutY);
            Assert.AreEqual(23f, root_child4.LayoutWidth);
            Assert.AreEqual(100f, root_child4.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(113f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(23f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(68f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(22f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            Assert.AreEqual(45f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(23f, root_child2.LayoutWidth);
            Assert.AreEqual(100f, root_child2.LayoutHeight);

            Assert.AreEqual(23f, root_child3.LayoutX);
            Assert.AreEqual(0f, root_child3.LayoutY);
            Assert.AreEqual(22f, root_child3.LayoutWidth);
            Assert.AreEqual(100f, root_child3.LayoutHeight);

            Assert.AreEqual(0f, root_child4.LayoutX);
            Assert.AreEqual(0f, root_child4.LayoutY);
            Assert.AreEqual(23f, root_child4.LayoutWidth);
            Assert.AreEqual(100f, root_child4.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_flex_basis_flex_shrink_row()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 101;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexShrink = 1;
            root_child0.FlexBasis = 100;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexBasis = 25;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexBasis = 25;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(101f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(51f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(51f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(25f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            Assert.AreEqual(76f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(25f, root_child2.LayoutWidth);
            Assert.AreEqual(100f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(101f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(51f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(25f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(25f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(25f, root_child2.LayoutWidth);
            Assert.AreEqual(100f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_flex_basis_overrides_main_size()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 113;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root_child0.Height = 20;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root_child2.Height = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_total_fractial()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Width = 87.4f;
            root.Height = 113.4f;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 0.7f;
            root_child0.FlexBasis = 50.3f;
            root_child0.Height = 20.3f;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1.6f;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1.1f;
            root_child2.Height = 10.7f;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(87f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(87f, root_child0.LayoutWidth);
            Assert.AreEqual(59f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(59f, root_child1.LayoutY);
            Assert.AreEqual(87f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(87f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(87f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(87f, root_child0.LayoutWidth);
            Assert.AreEqual(59f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(59f, root_child1.LayoutY);
            Assert.AreEqual(87f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(87f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_total_fractial_nested()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Width = 87.4f;
            root.Height = 113.4f;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 0.7f;
            root_child0.FlexBasis = 50.3f;
            root_child0.Height = 20.3f;
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode();
            root_child0_child0.FlexGrow = 1;
            root_child0_child0.FlexBasis = 0.3f;
            root_child0_child0.Bottom = 13.3f;
            root_child0_child0.Height = 9.9f;
            root_child0.Insert(0, root_child0_child0);

            YogaNode root_child0_child1 = new YogaNode();
            root_child0_child1.FlexGrow = 4;
            root_child0_child1.FlexBasis = 0.3f;
            root_child0_child1.Top = 13.3f;
            root_child0_child1.Height = 1.1f;
            root_child0.Insert(1, root_child0_child1);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1.6f;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1.1f;
            root_child2.Height = 10.7f;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(87f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(87f, root_child0.LayoutWidth);
            Assert.AreEqual(59f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(-13f, root_child0_child0.LayoutY);
            Assert.AreEqual(87f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(12f, root_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child1.LayoutX);
            Assert.AreEqual(25f, root_child0_child1.LayoutY);
            Assert.AreEqual(87f, root_child0_child1.LayoutWidth);
            Assert.AreEqual(47f, root_child0_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(59f, root_child1.LayoutY);
            Assert.AreEqual(87f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(87f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(87f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(87f, root_child0.LayoutWidth);
            Assert.AreEqual(59f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(-13f, root_child0_child0.LayoutY);
            Assert.AreEqual(87f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(12f, root_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child1.LayoutX);
            Assert.AreEqual(25f, root_child0_child1.LayoutY);
            Assert.AreEqual(87f, root_child0_child1.LayoutWidth);
            Assert.AreEqual(47f, root_child0_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(59f, root_child1.LayoutY);
            Assert.AreEqual(87f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(87f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_fractial_input_1()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 113.4f;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root_child0.Height = 20;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root_child2.Height = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_fractial_input_2()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 113.6f;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root_child0.Height = 20;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root_child2.Height = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(114f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(65f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(65f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(24f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(25f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(114f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(65f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(65f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(24f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(25f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_fractial_input_3()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Top = 0.3f;
            root.Width = 100;
            root.Height = 113.4f;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root_child0.Height = 20;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root_child2.Height = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(114f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(114f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

        [Test]
        public void Test_rounding_fractial_input_4()
        {
            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, true);

            YogaNode root = new YogaNode();
            root.Top = 0.7f;
            root.Width = 100;
            root.Height = 113.4f;

            YogaNode root_child0 = new YogaNode();
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root_child0.Height = 20;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.FlexGrow = 1;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode();
            root_child2.FlexGrow = 1;
            root_child2.Height = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(1f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(1f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(113f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(64f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(64f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(89f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(24f, root_child2.LayoutHeight);

            YogaNode.SetExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding, false);
        }

    }
}
